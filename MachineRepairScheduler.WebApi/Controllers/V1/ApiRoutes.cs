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
        }
    }
}
