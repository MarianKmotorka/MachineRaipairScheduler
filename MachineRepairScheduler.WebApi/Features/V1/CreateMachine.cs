using FluentValidation;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1
{
    public class CreateMachine
    {
        public class Command : IRequest<CommandResponse>
        {
            public string SerialNumber { get; set; }
            public string MachineName { get; set; }
            public string ManufacturerName { get; set; }
            public int YearOfManufacture { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, CommandResponse>
        {
            private DataContext _context;

            public CommandHandler(DataContext context)
            {
                _context = context;
            }

            public async Task<CommandResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                var machine = new Machine
                {
                    SerialNumber = request.SerialNumber,
                    MachineName = request.MachineName,
                    ManufacturerName = request.ManufacturerName,
                    YearOfManufacture = request.YearOfManufacture.ToString()
                };

                await _context.Machines.AddAsync(machine);
                await _context.SaveChangesAsync();

                return new CommandResponse { Success = true };
            }
        }

        public class CommandResponse
        {
            public bool Success { get; set; }
            public IEnumerable<string> Errors { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.YearOfManufacture).Must(x => x > 1700 && x <= DateTime.UtcNow.Year).WithMessage("Invalid YearOfManufacture");
                RuleFor(x => x.ManufacturerName).Must(x => x.Length > 2).WithMessage("Too Short");
                RuleFor(x => x.MachineName).Must(x => x.Length > 2).WithMessage("Too Short");
            }
        }
    }
}
