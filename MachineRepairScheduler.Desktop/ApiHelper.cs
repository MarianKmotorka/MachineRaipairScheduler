using MachineRepairScheduler.Desktop.Models;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace MachineRepairScheduler.Desktop
{
    class ApiHelper
    {
        private static string _baseURL = ConfigurationManager.AppSettings["Api"];
        static HttpClient client = new HttpClient();
        static async Task<Employee> GetEmployeesAsync(string path)
        {
            Employee employee = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                employee = await response.Content.ReadAsAsync<Employee>();
            }
            return employee;
        }
        public static async Task<LoginResponse> Login(string email, string password)
        {

            LoginResponse loginresponse = null;

            var data = new
            {
                email,
                password
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(_baseURL + "identity/login", data);

            loginresponse = await response.Content.ReadAsAsync<LoginResponse>();
            return loginresponse;
        }
    }
}
