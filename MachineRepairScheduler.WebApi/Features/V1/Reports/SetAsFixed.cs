using FluentValidation;
using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public class SetAsFixed
    {
        public class Command : IRequest<GenericResponse>
        {
            public string MalfunctionReportId { get; set; }
        }

        public class CommandHanlder : IRequestHandler<Command, GenericResponse>
        {
            private DataContext _context;

            public CommandHanlder(DataContext context)
            {
                _context = context;
            }

            public async Task<GenericResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var report = await _context.MalfunctionReports.SingleAsync(x => x.Id == request.MalfunctionReportId, cancellationToken);

                report.Fixed = true;
                report.FixedDate = DateTime.UtcNow;

                await _context.SaveChangesAsync(cancellationToken);

                return new GenericResponse { Success = true };
            }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            private DataContext _context;

            public CommandValidator(DataContext context)
            {
                _context = context;
                CascadeMode = CascadeMode.StopOnFirstFailure;

                //order matters - do not change
                RuleFor(x => x.MalfunctionReportId).MustAsync(Exist).WithMessage(x => $"Report with id {x.MalfunctionReportId} does not exist.");
                RuleFor(x => x.MalfunctionReportId).MustAsync(BeSchedulled).WithMessage("Cannot set unschedulled report as fixed.");
            }

            private async Task<bool> BeSchedulled(string reportId, CancellationToken cancellationToken)
            {
                return (await _context.MalfunctionReports.SingleAsync(x => x.Id == reportId, cancellationToken)).PlannedFixDate != null;
            }

            private async Task<bool> Exist(string reportId, CancellationToken cancellationToken)
            {
                return await _context.MalfunctionReports.AnyAsync(x => x.Id == reportId, cancellationToken);
            }
        }
    }
}
