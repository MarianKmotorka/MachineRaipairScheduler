﻿using System.Collections.Generic;

namespace MachineRepairScheduler.Desktop.Models
{
    public class EditSelectedUserResponse
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}