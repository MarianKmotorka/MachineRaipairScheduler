using AutoMapper;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public partial class GetAllReports
    {
        public class Query : IRequest<PagedResponse<ReportDto>>
        {
            public PaginationQuery PaginationQuery { get; set; }
            public Filter Filter { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, PagedResponse<ReportDto>>
        {
            private DataContext _context;
            private IMapper _mapper;

            public QueryHandler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<PagedResponse<ReportDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var reports = _context.MalfunctionReports
                    .Include(x => x.Machine)
                    .Include(x => x.MadeBy)
                    .ThenInclude(x => x.IdentityUser)
                    .Include(x => x.Technicians)
                    .ThenInclude(x => x.Technician)
                    .ThenInclude(x => x.IdentityUser)
                    .OrderByDescending(x => x.Priority);
                
                var filtered = ApplyFilter(request.Filter, reports);

                return await PaginationHelper.GetPagedResponse(filtered, request.PaginationQuery, _mapper.Map<ReportDto>, cancellationToken);
            }
        }
    }
}
