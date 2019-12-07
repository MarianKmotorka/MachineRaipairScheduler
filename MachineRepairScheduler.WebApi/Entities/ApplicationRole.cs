using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Entities
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole(string name)
        {
            Name = name;
        }
    }
}
