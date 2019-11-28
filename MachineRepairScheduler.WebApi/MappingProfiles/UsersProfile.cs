﻿using AutoMapper;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Features.V1;

namespace MachineRepairScheduler.WebApi.MappingProfiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<ApplicationUser, GetAllUsers.UserDto>()
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(x => x.Id));
        }
    }
}
