using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1.Responses
{
    public class GenericResponse
    {
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
