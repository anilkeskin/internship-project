using AutoMapper;
using InternshipProject.Server.Data.Models;
using InternshipProject.Shared.DTO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<Announcements, AnnouncementDTO>()
                .ReverseMap();
            CreateMap<User, UserDTO>();
            CreateMap<Debt, DebtDTO>();
            CreateMap<Expenses, ExpensesDTO>();
            CreateMap<Flats, FlatDTO>();
        }
    }
}
