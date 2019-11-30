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
        public static ApiHelper Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new ApiHelper();
                return _instance;
            }
        }

        private static ApiHelper _instance = new ApiHelper();
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

        public async Task<GetUsersResponse> GetUsersAsync(int pagenumber = 1, int pageSize = 11, string roleFilter = "", string emailFilter = "")
        {
            var response = await _client.GetAsync($"users?PageNumber={pagenumber}&PageSize={pageSize}&Role={roleFilter}&EmailAddress={emailFilter}");
            return await response.Content.ReadAsAsync<GetUsersResponse>();
        }
        public async Task<GetSelectedUserResponse> GetSelectedUserAsync(string userID)
        {
            GetSelectedUserResponse user = null;

            var response = await _client.GetAsync("users/" + userID);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<GetSelectedUserResponse>();
            }
            return user;
        }
        public async Task<EditSelectedUserResponse> EditSelectedUserAsync(string userID, string email, string password, string firstName, string lastName, string phoneNumber, string birthCertificateNumber, Role role)
        {
            var data = new
            {
                emailAddress = email,
                password,
                firstName,
                lastName,
                phoneNumber,
                birthCertificateNumber,
                role
            };

            var response = await _client.PutAsJsonAsync("users/" + userID, data);
            return await response.Content.ReadAsAsync<EditSelectedUserResponse>();
        }
        public async Task<LoginResponse> Login(string email, string password)
        {
            var data = new
            {
                email,
                password
            };

            var response = await _client.PostAsJsonAsync("identity/login", data);
            var loginresponse = await response.Content.ReadAsAsync<LoginResponse>();

            if (loginresponse.Success)
                _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginresponse.Token}");

            return loginresponse;
        }
        public async Task<RegisterResponse> Register(string email, string password, string firstName, string lastName, string phoneNumber, string birthCertificateNumber, Role role)
        {
            var data = new
            {
                emailAddress = email,
                password,
                firstName,
                lastName,
                phoneNumber,
                birthCertificateNumber,
                role
            };

            var response = await _client.PostAsJsonAsync("identity/register", data);
            return await response.Content.ReadAsAsync<RegisterResponse>();
        }
    }
}
