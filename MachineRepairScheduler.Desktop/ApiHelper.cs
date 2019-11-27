using MachineRepairScheduler.Desktop.Models;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MachineRepairScheduler.Desktop
{
    public class ApiHelper
    {
        private static ApiHelper _instance = new ApiHelper();
        public static ApiHelper Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new ApiHelper();
                }

                return _instance;
            }
        }

        private HttpClient _client = new HttpClient();

        private ApiHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            _client.DefaultRequestHeaders.Clear();
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings["Api"]);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Employee> GetEmployeesAsync(string path)
        {
            Employee employee = null;
            HttpResponseMessage response = await _client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                employee = await response.Content.ReadAsAsync<Employee>();
            }
            return employee;
        }
        public async Task<LoginResponse> Login(string email, string password)
        {

            LoginResponse loginresponse = null;

            var data = new
            {
                email,
                password
            };

            HttpResponseMessage response = await _client.PostAsJsonAsync("identity/login", data);

            loginresponse = await response.Content.ReadAsAsync<LoginResponse>();

            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginresponse.Token}");
            return loginresponse;
        }
        public async Task<RegisterResponse> Register(string email, string password, Role role)
        {
            var data = new
            {
                emailAddress = email,
                password,
                role
            };
            HttpResponseMessage response = await _client.PostAsJsonAsync("identity/register", data);

            return  await response.Content.ReadAsAsync<RegisterResponse>();
        }
    }
}
