namespace MachineRepairScheduler.WebApi.Services
{
    public interface IRequestTokenInfo
    {
        string Email { get; set; }
        string JwtTokenId { get; }
        string UserId { get; }
        string UserRole { get; }
    }
}