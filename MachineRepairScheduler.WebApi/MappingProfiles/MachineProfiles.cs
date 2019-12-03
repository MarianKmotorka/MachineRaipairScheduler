using AutoMapper;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Features.V1.Machines;

namespace MachineRepairScheduler.WebApi.MappingProfiles
{
    public class MachineProfiles : Profile
    {
        public MachineProfiles()
        {
            CreateMap<Machine, GetAllMachines.MachineDto>();
            CreateMap<Machine, GetMachine.MachineDto>();
        }
    }
}
