using AutoMapper;
using MachineRepairScheduler.WebApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public class GetReport
    {
        public class Query : IRequest<GetAllReports.ReportDto>
        {
            [JsonIgnore]
            public string ReportId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, GetAllReports.ReportDto>
        {
            private DataContext _context;
            private IMapper _mapper;

            public QueryHandler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetAllReports.ReportDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var report = await _context.MalfunctionReports
                    .Include(x => x.Machine)
                    .Include(x => x.MadeBy)
                    .ThenInclude(x => x.IdentityUser)
                    .Include(x => x.Technicians)
                    .ThenInclude(x => x.Technician)
                    .ThenInclude(x => x.IdentityUser)
                    .SingleOrDefaultAsync(x => x.Id == request.ReportId);

                if (report is null) return null;

                return _mapper.Map<GetAllReports.ReportDto>(report);
            }
        }
    }
}
