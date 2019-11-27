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
            public const string Register = _base + "identity/register";
            public const string Login = _base + "identity/login";
        }
    }
}
