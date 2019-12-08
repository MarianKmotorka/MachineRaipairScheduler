using FluentValidation;
using MachineRepairScheduler.WebApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Machines
{
    public class EditMachine
    {
        public class Command : IRequest<CommandResponse>
        {
            [JsonIgnore]
            public string MachineId { get; set; }
            public string SerialNumber { get; set; }
            public string MachineName { get; set; }
            public string ManufacturerName { get; set; }
            public string YearOfManufacture { get; set; }
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
                var machine = await _context.Machines.SingleOrDefaultAsync(x => x.Id == request.MachineId, cancellationToken);

                if (machine is null)
                    return new CommandResponse { Errors = new[] { $"Machine with id {request.MachineId} does not exist." } };

                if (await _context.Machines.AnyAsync(x => x.SerialNumber == request.SerialNumber && x.SerialNumber != machine.SerialNumber)) 
                    return new CommandResponse { Errors = new[] { $"Machine with serial {request.SerialNumber} already exists." } };

                machine.SerialNumber = request.SerialNumber;
                machine.MachineName = request.MachineName;
                machine.ManufacturerName = request.ManufacturerName;
                machine.YearOfManufacture = request.YearOfManufacture;
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
                RuleFor(x => x.YearOfManufacture).Must(BeValidYear).WithMessage("Invalid.");
                RuleFor(x => x.ManufacturerName).Must(x => x.Length > 2).WithMessage("Too Short");
                RuleFor(x => x.MachineName).Must(x => x.Length > 2).WithMessage("Too Short");
            }

            private bool BeValidYear(string value)
            {
                if (string.IsNullOrEmpty(value)) return true;

                if (!int.TryParse(value, out var year)) return false;

                return year > 1700 && year <= DateTime.UtcNow.Year;
            }
        }
    }
}
