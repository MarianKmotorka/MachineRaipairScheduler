using AutoMapper;
using MachineRepairScheduler.WebApi.Domain;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1;

namespace MachineRepairScheduler.WebApi.MappingProfiles
{
    public class IdentityProfile : Profile
    {
        public IdentityProfile()
        {
            CreateMap<AuthenticationResult, Login.CommandResponse>();
            CreateMap<OperationResult, Register.CommandResponse>();
            CreateMap<Register.Command, RegisterModel>();
        }
    }
}
