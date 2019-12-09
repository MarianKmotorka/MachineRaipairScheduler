using MachineRepairScheduler.Desktop.Models;
using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Responses
{
    public class GetMachinesResponse
    {
        public IEnumerable<Machine> Data { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Pages { get; set; }
    }
}
