using FluentValidation;
using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public class CreateReport
    {
        public class Command : IRequest<GenericResponse>
        {
            [JsonIgnore]
            public string EmployeeId { get; set; }
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
                var employee = await _context.Employees.SingleAsync(x => x.Id == request.EmployeeId);
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

            public CommandValidator(DataContext context)
            {
                _context = context;

                RuleFor(x => x.Prioroty).Must(x => x >= 0 && (int)x < 3).WithMessage("Out Of Range (0 - 2)");
                RuleFor(x => x.Message).Must(x => x.Length > 3).WithMessage("Must contain message.");
                RuleFor(x => x.MachineId).MustAsync(MachineExists).WithMessage(x => $"Machine with id {x.MachineId} doesnt exist.");
            }

            private async Task<bool> MachineExists(string machineId, CancellationToken cancellationToken)
            {
                return await _context.Machines.AnyAsync(x => x.Id == machineId, cancellationToken);
            }
        }
    }
}
