using AutoMapper;
using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Domain;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1.Users;

namespace MachineRepairScheduler.WebApi.MappingProfiles
{
    public class IdentityProfile : Profile
    {
        public IdentityProfile()
        {
            CreateMap<AuthenticationResult, Login.CommandResponse>();
            CreateMap<OperationResult, GenericResponse>();
            CreateMap<Register.Command, RegisterModel>();
        }
    }
}
