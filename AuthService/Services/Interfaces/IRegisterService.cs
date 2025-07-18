using AuthService.DTO;
using Microsoft.AspNetCore.Identity;

namespace AuthService.Services.Interfaces
{
    public interface IRegisterService
    {
        Task<IdentityResult> RegisterUserAsync(RegisterDTO model);
    }
}