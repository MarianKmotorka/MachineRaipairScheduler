using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Pagination
{
    public class PaginationQuery
    {
        private int _pageSize;
        private int _pageNumber;

        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value > 100) value = 100;
                if (value < 2) value = 2;
                _pageSize = value;
            }
        }
        public int PageNumber
        {
            get => _pageNumber;
            set
            {
                if (value < 1) value = 1;
                _pageNumber = value;
            }
        }

        public PaginationQuery()
        {
            PageSize = 10;
            PageNumber = 1;
        }
    }
}
