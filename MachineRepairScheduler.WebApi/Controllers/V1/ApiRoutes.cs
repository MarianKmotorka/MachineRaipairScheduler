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

        public static class Users
        {
            public const string GetAllUsers = _base + "users";
            public const string GetUser = _base + "users/{userId}";
            public const string DeleteUser = _base + "users/{userId}";
            public const string EditUser = _base + "users/{userId}";
        }

        public static class Me
        {
            public const string ChangePassword = _base + "me/password";
        }

        public static class Machine
        {
            public const string GetAllMachines = _base + "machines";
            public const string GetMachine = _base + "machines/{machineId}";
            public const string DeleteMachine = _base + "machines/{machineId}";
            public const string CreateMachine = _base + "machines";
        }
    }
}
