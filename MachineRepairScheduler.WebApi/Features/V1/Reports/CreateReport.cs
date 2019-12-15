using FluentValidation;
using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public class CreateReport
    {
        public class Command : IRequest<GenericResponse>
        {
            [JsonIgnore]
            public string CreatorId { get; set; }
            public string MachineId { get; set; }
            public string Message { get; set; }
            public MalfunctionReport.PriorityEnum Prioroty { get; set; }
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
                var employee = await _context.Employees.SingleAsync(x => x.Id == request.CreatorId);
                var machine = await _context.Machines.SingleAsync(x => x.Id == request.MachineId);

                var report = new MalfunctionReport
                {
                    MadeBy = employee,
                    Machine = machine,
                    Message = request.Message,
                    Priority = request.Prioroty,
                };

                _context.MalfunctionReports.Add(report);
                await _context.SaveChangesAsync(cancellationToken);

                return new GenericResponse { Success = true };
            }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            private DataContext _context;
            private IRequestTokenInfo _requestTokenInfo;

            public CommandValidator(DataContext context, IRequestTokenInfo requestTokenInfo)
            {
                _context = context;
                _requestTokenInfo = requestTokenInfo;

                RuleFor(x => x.Prioroty).Must(x => x >= 0 && (int)x < 3).WithMessage("Out Of Range (0 - 2)");
                RuleFor(x => x.Message).Must(x => x.Length > 3).WithMessage("Must contain message.");
                RuleFor(x => x.MachineId).MustAsync(MachineExists).WithMessage(x => $"Machine with id {x.MachineId} doesnt exist.");
                RuleFor(x => x.MachineId).MustAsync(OneReportPerMachinePerUserIn24Hrs).WithMessage("You can only create one report per machine within 24 hours.");
            }

            private async Task<bool> OneReportPerMachinePerUserIn24Hrs(string machineId, CancellationToken cancellationToken)
            {
                var existingReports = await _context.MalfunctionReports
                    .Where(x => x.MadeById == _requestTokenInfo.UserId)
                    .Where(x => x.MachineId == machineId)
                    .ToListAsync(cancellationToken);

                if (!existingReports.Any()) return true;

                return DateTime.UtcNow - existingReports.Max(x => x.CreateDate) > TimeSpan.FromHours(24);
            }

            private async Task<bool> MachineExists(string machineId, CancellationToken cancellationToken)
            {
                return await _context.Machines.AnyAsync(x => x.Id == machineId, cancellationToken);
            }
        }
    }
}
