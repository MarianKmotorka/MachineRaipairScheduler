using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Models
{
    public class GetMachinesResponse
    {
        public IEnumerable<User> Data { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Pages { get; set; }
    }
}
