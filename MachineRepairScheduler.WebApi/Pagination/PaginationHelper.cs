using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Pagination
{
    public class PaginationHelper
    {
        public static async Task<PagedResponse<TResponseDto>> GetPagedResponse<TResponseDto, TEntity>
            (IQueryable<TEntity> data, PaginationQuery query, Func<TEntity, TResponseDto> mapper, CancellationToken cancellationToken)
        {
            var skip = (query.PageNumber - 1) * query.PageSize;

            var result = (await data.Skip(skip).Take(query.PageSize).ToListAsync(cancellationToken)).Select(mapper);

            return new PagedResponse<TResponseDto>(result)
            {
                PageNumber = query.PageNumber,
                Pages = (int)Math.Ceiling((decimal)data.Count() / query.PageSize),
                PageSize = query.PageSize
            };
        }

        public static PagedResponse<T> GetPagedResponse<T>(IEnumerable<T> data, PaginationQuery query)
        {
            var skip = (query.PageNumber - 1) * query.PageSize;

            var result =  data.Skip(skip).Take(query.PageSize).ToList();

            return new PagedResponse<T>(result)
            {
                PageNumber = query.PageNumber,
                Pages = (int)Math.Ceiling((decimal)data.Count() / query.PageSize),
                PageSize = query.PageSize
            };
        }
    }
}
