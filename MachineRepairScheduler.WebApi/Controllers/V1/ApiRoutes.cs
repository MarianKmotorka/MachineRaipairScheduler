using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{
    public static class ApiRoutes
    {
        private const string _base = "api/v1/";

        public static class Identity
        {
            public const string RegisterEmployee = _base + "identity/register-employee";
            public const string RegisterTechnician = _base + "identity/register-technician";
            public const string RegisterPlanningManager = _base + "identity/register-planning-manager";
            public const string Login = _base + "identity/login";
        }
    }
}
