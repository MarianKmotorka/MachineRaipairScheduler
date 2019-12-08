using AutoMapper;
using MachineRepairScheduler.WebApi.Entities;
using System.Linq;
using MachineRepairScheduler.WebApi.Features.V1.Reports;

namespace MachineRepairScheduler.WebApi.MappingProfiles
{
    public class MalfunctionReportProfile : Profile
    {
        public MalfunctionReportProfile()
        {
            CreateMap<MalfunctionReport, GetAllReports.ReportDto>()
                .ForMember(dest => dest.MachineName, opt => opt.MapFrom(x => x.Machine.MachineName))
                .ForMember(dest => dest.Technicians, opt =>
                {
                    opt.MapFrom(x => x.Technicians.Select(t => new GetAllReports.UserLookup
                    { 
                        Id = t.TechnicianId, 
                        Name = $"{t.Technician.IdentityUser.FirstName} {t.Technician.IdentityUser.LastName}",
                        EmailAddress = t.Technician.IdentityUser.Email
                    }));
                })
                .ForMember(dest => dest.MadeBy, opt =>
                {
                    opt.MapFrom(x => new GetAllReports.UserLookup
                    {
                        Id = x.MadeBy.Id,
                        Name = $"{x.MadeBy.IdentityUser.FirstName} {x.MadeBy.IdentityUser.LastName}",
                        EmailAddress = x.MadeBy.IdentityUser.Email
                    });
                });
        }
    }
}
