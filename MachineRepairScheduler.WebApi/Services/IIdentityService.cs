using System.Threading.Tasks;
using MachineRepairScheduler.WebApi.Domain;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;

namespace MachineRepairScheduler.WebApi.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> LoginAsync(string email, string password);
        Task<OperationResult> RegisterAsync(string email, string password, params string[] roles);
    }
}