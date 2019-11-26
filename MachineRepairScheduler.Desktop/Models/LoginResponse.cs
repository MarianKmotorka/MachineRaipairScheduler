using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Models
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public Role UserRole { get; set; }
        public List<string> Errors { get; set; }
    }
}
