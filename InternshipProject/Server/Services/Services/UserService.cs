using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.QueryableExtensions;
using InternshipProject.Server.Data.Context;
using InternshipProject.Server.Services.Infrastruce;
using InternshipProject.Shared.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Services
{
    public class UserService : IUserService
    {
        
        private readonly IMapper mapper;
        private readonly InternshipProjectDbContext context;
        private readonly IConfiguration configuration;

        public UserService(IMapper Mapper, InternshipProjectDbContext Context, IConfiguration Configuration)
        {
            mapper = Mapper;
            context = Context;
            configuration = Configuration;
        }
        
        public async Task<UserDTO> CreateUser(UserDTO User)
        {
            var dbUser = await context.Users.Where(i => i.Id == User.Id).FirstOrDefaultAsync();

            if (dbUser != null)
                throw new Exception("User already exists");

            dbUser = mapper.Map<Data.Models.User>(User);

            await context.Users.AddAsync(dbUser);
            int result = await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(dbUser);
        }

        public async Task<bool> DeleteUserById(Guid Id)
        {
            var dbUser = await context.Users.FirstOrDefaultAsync(i => i.Id == Id);

            if (dbUser == null)
                throw new Exception("User not found");

            context.Users.Remove(dbUser);
            int result = await context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<UserDTO> GetUserById(Guid Id)
        {
            return await context.Users
                        .Where(i => i.Id == Id)
                        .ProjectTo<UserDTO>(mapper.ConfigurationProvider)
                        .FirstOrDefaultAsync();
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            return await context.Users
                        .Where(i => i.IsAdmin)
                        .ProjectTo<UserDTO>(mapper.ConfigurationProvider)
                        .ToListAsync();
        }

        public async Task<UserDTO> UpdateUser(UserDTO User)
        {
            var dbUser = await context.Users.Where(i => i.Id == User.Id).FirstOrDefaultAsync();

            if (dbUser == null)
                throw new Exception("User not found");


            mapper.Map(User, dbUser);

            int result = await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(dbUser);
        }
        
        
    }
}
