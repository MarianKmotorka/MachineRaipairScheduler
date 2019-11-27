﻿using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Models
{
    public class RegisterResponse
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
