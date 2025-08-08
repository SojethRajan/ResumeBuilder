using AuthService.DTO;
using AuthService.Models;
using AuthService.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace AuthService.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private  readonly ITokenService tokenService;

        public AuthenticateService(UserManager<ApplicationUser> userManager, ITokenService tokenService
            )
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
        }

        public async Task<string> LoginUserAsync(LoginDTO model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                return "User not found";
            }

            var result = await userManager.CheckPasswordAsync(user, model.Password);

            if (!result)
            {
                return "Invalid password";
            }

            var roles = await userManager.GetRolesAsync(user);

            var token = tokenService.CreateToken(user, roles);

            return token;
        }
    }
}
