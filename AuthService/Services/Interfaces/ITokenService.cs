using Microsoft.AspNetCore.Identity;

namespace AuthService.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(IdentityUser user, IList<string> roles);
    }
}
