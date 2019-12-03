using AutoMapper;
using MachineRepairScheduler.WebApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Machines
{
    public class GetMachine
    {
        public class Query : IRequest<MachineDto>
        {
            [JsonIgnore]
            public string MachineId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, MachineDto>
        {
            private DataContext _context;
            private IMapper _mapper;

            public QueryHandler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<MachineDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var machine = await _context.Machines.SingleOrDefaultAsync(x => x.Id == request.MachineId);
                if (machine is null) return null;
                return _mapper.Map<MachineDto>(machine);
            }
        }

        public class MachineDto
        {
            public string Id { get; set; }
            public string SerialNumber { get; set; }
            public string MachineName { get; set; }
            public string ManufacturerName { get; set; }
            public string YearOfManufacture { get; set; }
        }
    }
}
