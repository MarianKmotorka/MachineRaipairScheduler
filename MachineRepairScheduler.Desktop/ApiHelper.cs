﻿using MachineRepairScheduler.Desktop.Models;
using MachineRepairScheduler.Desktop.Responses;
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
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/problem+json"));
        }

        public async Task<GetUsersResponse> GetUsersAsync(int pageNumber = 1, int pageSize = 11, string roleFilter = "", string emailFilter = "")
        {
            var response = await _client.GetAsync($"users?PageNumber={pageNumber}&PageSize={pageSize}&Role={roleFilter}&EmailAddress={emailFilter}");
            return await response.Content.ReadAsAsync<GetUsersResponse>();
        }
        public async Task<GetMachinesResponse> GetMachinesAsync(int pageNumber = 1, int pageSize = 11, string nameFilter = "", string serialNumberFilter = "")
        {
            var response = await _client.GetAsync($"machines?PageNumber={pageNumber}&PageSize={pageSize}&MachineName={nameFilter}&SerialNumber={serialNumberFilter}");
            return await response.Content.ReadAsAsync<GetMachinesResponse>();
        }
        public async Task<GetReportsResponse> GetReportsAsync(int pageNumber = 1, int pageSize = 11, string machineNameFilter = "", bool notScheduledFilter = false, bool scheduledFilter = false, bool notFixedFilter = false, bool fixedFilter = false, bool overdueFilter = false)
        {
            var response = await _client.GetAsync($"reports?MachineName={machineNameFilter}&NotScheduled={notScheduledFilter}&Scheduled={scheduledFilter}&NotFixed={notFixedFilter}&Fixed={fixedFilter}&Overdue={overdueFilter}&PageSize={pageSize}&PageNumber={pageNumber}");
            return await response.Content.ReadAsAsync<GetReportsResponse>();
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
        public async Task<GetSelectedMachineResponse> GetSelectedMachineAsync(string machineID)
        {
            GetSelectedMachineResponse machine = null;

            var response = await _client.GetAsync("machines/" + machineID);
            if (response.IsSuccessStatusCode)
            {
                machine = await response.Content.ReadAsAsync<GetSelectedMachineResponse>();
            }
            return machine;
        }
        public async Task<GetSelectedReportResponse> GetSelectedReportAsync(string reportID)
        {
            GetSelectedReportResponse report = null;

            var response = await _client.GetAsync("reports/" + reportID);
            if (response.IsSuccessStatusCode)
            {
                report = await response.Content.ReadAsAsync<GetSelectedReportResponse>();
            }
            return report;
        }
        public async Task<ChangeFixedStatusResponse> ChangeFixedStatusAsync(string reportID)
        {
            var response = await _client.PutAsJsonAsync("reports/" + reportID + "/fix", new { });
            return await response.Content.ReadAsAsync<ChangeFixedStatusResponse>();
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
        public async Task<PlanFixResponse> PlanFixAsync(string reportID, string[] technicianIds, DateTime plannedFixDateUtc)
        {
            var data = new
            {
                technicianIds,
                plannedFixDateUtc
            };

            var response = await _client.PutAsJsonAsync("reports/" + reportID + "/technicians", data);
            return await response.Content.ReadAsAsync<PlanFixResponse>();
        }
        public async Task<EditSelectedMachineResponse> EditSelectedMachineAsync(string machineID, string serialNumber, string machineName, string manufacturerName, string yearOfManufacture)
        {
            var data = new
            {
                serialNumber,
                machineName,
                manufacturerName,
                yearOfManufacture
            };

            var response = await _client.PutAsJsonAsync("machines/" + machineID, data);
            return await response.Content.ReadAsAsync<EditSelectedMachineResponse>();
        }
        public async Task<DeleteSelectedUserResponse> DeleteSelectedUserAsync(string userID)
        {
            var response = await _client.DeleteAsync("users/" + userID);
            return await response.Content.ReadAsAsync<DeleteSelectedUserResponse>();
        }
        public async Task<DeleteSelectedMachineResponse> DeleteSelectedMachineAsync(string machineID)
        {
            var response = await _client.DeleteAsync("machines/" + machineID);
            if (response.IsSuccessStatusCode) return new DeleteSelectedMachineResponse { Success = true };

            var message = await response.Content.ReadAsAsync<string>();
            return new DeleteSelectedMachineResponse { ErrorMessage = message };
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
        public async Task<AddMachineResponse> AddMachineAsync(string serialNumber, string machineName, string manufacturerName, string yearOfManufacture)
        {
            var data = new
            {
                serialNumber,
                machineName,
                manufacturerName,
                yearOfManufacture,
            };

            var response = await _client.PostAsJsonAsync("machines", data);
            return await response.Content.ReadAsAsync<AddMachineResponse>();
        }
        public async Task<ReportMalfunctionResponse> ReportMalfunctionAsync(string machineId, string message, Priority prioroty)
        {
            var data = new
            {
                machineId,
                message,
                prioroty
            };

            var response = await _client.PostAsJsonAsync("reports", data);
            return await response.Content.ReadAsAsync<ReportMalfunctionResponse>();
        }
        public async Task<ChangePasswordResponse> ChangePasswordAsync(string currentPassword, string newPassword)
        {
            var data = new
            {
                currentPassword,
                newPassword
            };

            var response = await _client.PostAsJsonAsync("me/password", data);
            return await response.Content.ReadAsAsync<ChangePasswordResponse>();
        }
        public void LogoutUser()
        {
            _client.DefaultRequestHeaders.Remove("Authorization");
            CurrentUser.User.ClearUser();
        }
    }
}
