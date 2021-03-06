﻿using FluentValidation;
using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Machines
{
    public class CreateMachine
    {
        public class Command : IRequest<GenericResponse>
        {
            public string SerialNumber { get; set; }
            public string MachineName { get; set; }
            public string ManufacturerName { get; set; }
            public string YearOfManufacture { get; set; }
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
                if (await _context.Machines.AnyAsync(x => x.SerialNumber == request.SerialNumber))
                    return new GenericResponse { Errors = new[] { $"Machine with serial {request.SerialNumber} already exists." } };

                var machine = new Machine
                {
                    SerialNumber = request.SerialNumber,
                    MachineName = request.MachineName,
                    ManufacturerName = request.ManufacturerName,
                    YearOfManufacture = request.YearOfManufacture
                };

                await _context.Machines.AddAsync(machine);
                await _context.SaveChangesAsync();

                return new GenericResponse { Success = true };
            }
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

                return year > 1700 && year < DateTime.UtcNow.Year;
            }
        }
    }
}
