using FluentValidation;
using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Entities.Joins;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public class AssignTechniciansToReport
    {
        public class Command : IRequest<GenericResponse>
        {
            [JsonIgnore]
            public string ReportId { get; set; }
            public IEnumerable<string> TechnicianIds { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, GenericResponse>
        {
            private DataContext _context;

            public CommandHandler(DataContext context)
            {
                _context = context;
            }

            public async Task<GenericResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var report = await _context.MalfunctionReports
                    .Include(x => x.Technicians)
                    .ThenInclude(x => x.Technician)
                    .SingleOrDefaultAsync(x => x.Id == request.ReportId);

                if (report is null) return new GenericResponse { Errors = new[] { $"Report with id {request.ReportId} does not exist." } };

                var technicians = _context.Technicians.Where(x => request.TechnicianIds.Contains(x.Id));

                foreach(var tech in technicians)
                {
                    report.Technicians.Add(new MalfunctionReport_Technician { Technician = tech });
                }

                await _context.SaveChangesAsync();

                return new GenericResponse { Success = true };
            }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            private UserManager<ApplicationUser> _userManager;

            public CommandValidator(UserManager<ApplicationUser> userManager)
            {
                _userManager = userManager;

                RuleForEach(x => x.TechnicianIds).MustAsync(BeTechnician).WithMessage("One or more ids does not belong to technicians.");
                RuleFor(x => x.TechnicianIds).Must(x => x.Any()).WithMessage("Must contain atleat one technician");
            }

            private async Task<bool> BeTechnician(string id, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByIdAsync(id);

                if (user is null) return false;

                return (await _userManager.GetRolesAsync(user)).Single() == Roles.Technician;
            }

        }
    }
}
