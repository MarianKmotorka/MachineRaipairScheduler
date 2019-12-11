using AutoMapper;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Reports
{
    public partial class GetAllReports
    {
        public class Query : IRequest<PagedResponse<ReportDto>>
        {
            [JsonIgnore]
            public string RequesterId { get; set; }
            public PaginationQuery PaginationQuery { get; set; }
            public Filter Filter { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, PagedResponse<ReportDto>>
        {
            private DataContext _context;
            private UserManager<ApplicationUser> _userManager;
            private IMapper _mapper;

            public QueryHandler(DataContext context, UserManager<ApplicationUser> userManager, IMapper mapper)
            {
                _context = context;
                _userManager = userManager;
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

                var requester = await _userManager.FindByIdAsync(request.RequesterId);

                if ((await _userManager.GetRolesAsync(requester)).Single() == Roles.Technician)
                    request.Filter.TechnicianId = request.RequesterId;
                
                var filtered = ApplyFilter(request.Filter, reports);

                return await PaginationHelper.GetPagedResponse(filtered, request.PaginationQuery, _mapper.Map<ReportDto>, cancellationToken);
            }
        }
    }
}
