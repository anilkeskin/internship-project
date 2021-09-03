using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Infrastruce
{
    public interface IUserService
    {
        public Task<UserDTO> GetUserById(Guid Id);

        public Task<List<UserDTO>> GetUsers();

        public Task<UserDTO> CreateUser(UserDTO User);

        public Task<UserDTO> UpdateUser(UserDTO User);

        public Task<bool> DeleteUserById(Guid Id);

    }
}
