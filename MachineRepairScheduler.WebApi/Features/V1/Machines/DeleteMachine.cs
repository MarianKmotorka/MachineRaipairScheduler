using MachineRepairScheduler.WebApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Machines
{
    public class DeleteMachine
    {
        public class Command : IRequest<bool>
        {
            public string MachineId { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, bool>
        {
            private DataContext _context;

            public CommandHandler(DataContext context)
            {
                _context = context;
            }

            public async Task<bool> Handle(Command request, CancellationToken cancellationToken)
            {
                var machine = await _context.Machines.SingleOrDefaultAsync(x => x.Id == request.MachineId);

                if (machine is null) return false;

                _context.Remove(machine);
                await _context.SaveChangesAsync();

                return true;
            }
        }
    }
}
