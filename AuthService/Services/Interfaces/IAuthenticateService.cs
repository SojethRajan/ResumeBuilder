using AuthService.DTO;

namespace AuthService.Services.Interfaces
{
    public interface IAuthenticateService
    {
        Task<string> LoginUserAsync(LoginDTO model);
    }
}
