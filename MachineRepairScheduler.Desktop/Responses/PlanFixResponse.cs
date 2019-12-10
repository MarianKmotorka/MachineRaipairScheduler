using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Responses
{
    public class PlanFixResponse
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
