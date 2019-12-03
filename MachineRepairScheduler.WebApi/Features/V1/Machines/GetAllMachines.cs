using AutoMapper;
using MachineRepairScheduler.WebApi.Data;
using MachineRepairScheduler.WebApi.Entities;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Features.V1.Machines
{
    public class GetAllMachines
    {
        public class Query : IRequest<PagedResponse<MachineDto>>
        {
            public Filter Filter { get; set; }
            public PaginationQuery PaginationQuery { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, PagedResponse<MachineDto>>
        {
            private DataContext _context;
            private IMapper _mapper;

            public QueryHandler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<PagedResponse<MachineDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var machines = _context.Machines.AsQueryable();
                machines = ApplyFiltering(request.Filter, machines);

                var pageCount = (int)Math.Ceiling((double)machines.Count() / request.PaginationQuery.PageSize);
                var skip = (request.PaginationQuery.PageNumber - 1) * request.PaginationQuery.PageSize;

                var pagedMachines = (await machines
                    .Skip(skip)
                    .Take(request.PaginationQuery.PageSize)
                    .ToListAsync(cancellationToken))
                    .Select(_mapper.Map<MachineDto>);

                return new PagedResponse<MachineDto>(pagedMachines)
                {
                    PageNumber = request.PaginationQuery.PageNumber,
                    Pages = pageCount,
                    PageSize = request.PaginationQuery.PageSize
                };
            }

            private IQueryable<Machine> ApplyFiltering(Filter filter, IQueryable<Machine> query)
            {
                if (!string.IsNullOrEmpty(filter.MachineName))
                    query = query.Where(x => x.MachineName.Contains(filter.MachineName));
                if (!string.IsNullOrEmpty(filter.SerialNumber))
                    query = query.Where(x => x.SerialNumber.Contains(filter.SerialNumber));
                if (!string.IsNullOrEmpty(filter.ManufacturerName))
                    query = query.Where(x => x.ManufacturerName.Contains(filter.ManufacturerName));

                return query;
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

        public class Filter
        {
            public string SerialNumber { get; set; }
            public string MachineName { get; set; }
            public string ManufacturerName { get; set; }
        }
    }
}
