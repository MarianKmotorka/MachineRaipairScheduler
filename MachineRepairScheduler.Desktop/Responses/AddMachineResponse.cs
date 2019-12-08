using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Responses
{
    public class AddMachineResponse
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
