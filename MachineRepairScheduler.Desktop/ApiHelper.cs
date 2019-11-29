using MachineRepairScheduler.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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

        public async Task<GetUsersResponse> GetUsersAsync(int pagenumber, string expression)
        {
            GetUsersResponse users = null;
            GetUsersResponse users1 = null;
            GetUsersResponse users2 = null;
            GetUsersResponse users3 = null;
            List<IEnumerable<User>> usersList = new List<IEnumerable<User>>();

            string paging = "PageSize=11&PageNumber=" + pagenumber.ToString();
            string data = "?" + paging;
            string[] expressionParams = { "EmailAddress=", "FirstName=", "LastName=" };
            var response = await _client.GetAsync("users" + data);
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<GetUsersResponse>();
            }

            if (expression != "")
            {
                data = "?" + expressionParams[0] + expression + "&" + paging;
                var response1 = await _client.GetAsync("users" + data);
                if (response1.IsSuccessStatusCode)
                {
                    users1 = await response1.Content.ReadAsAsync<GetUsersResponse>();
                    if (users1.Data.Count() != 0)
                        usersList.Add(users1.Data);
                }
                data = "?" + expressionParams[1] + expression + "&" + paging;
                var response2 = await _client.GetAsync("users" + data);
                if (response2.IsSuccessStatusCode)
                {
                    users2 = await response2.Content.ReadAsAsync<GetUsersResponse>();
                    if (users2.Data.Count() != 0)
                        usersList.Add(users2.Data);
                }
                data = "?" + expressionParams[2] + expression + "&" + paging;
                var response3 = await _client.GetAsync("users" + data);
                if (response3.IsSuccessStatusCode)
                {
                    users3 = await response3.Content.ReadAsAsync<GetUsersResponse>();
                    if (users3.Data.Count() != 0)
                        usersList.Add(users3.Data);
                }
                if (usersList.Count > 1)
                {
                    var union = users1.Data.Union(users2.Data, new UserComparer());
                    var union2 = union.Union(users3.Data, new UserComparer());
                    users.Data = union;
                    //union.OrderBy(x => x.UserID).ToList().ForEach(x => users.Data);
                }
                else
                {
                    users.Data = usersList.ElementAt(0);
                }
                users.Pages = (users.Data.Count() / 11) + 1;
            }
            return users;
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
