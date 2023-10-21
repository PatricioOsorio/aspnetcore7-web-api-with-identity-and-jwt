using ApiNet7WithJwtAndIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace ApiNet7WithJwtAndIdentity.Services
{
  public class AuthService : IAuthService
  {
    private readonly UserManager<IdentityUser> _userManager;

    public AuthService(UserManager<IdentityUser> userManager)
    {
      _userManager = userManager;
    }

    public async Task<bool> RegisterUserAsync(LoginUser loginUser)
    {
      var identityUser = new IdentityUser { UserName = loginUser.UserName, Email = loginUser.UserName };

      var result = await _userManager.CreateAsync(identityUser, loginUser.Password);

      return result.Succeeded;
    }

    public async Task<bool> LoginAsync(LoginUser loginUser)
    {
      var identityUser = await _userManager.FindByNameAsync(loginUser.UserName);

      if (identityUser is null) return false;

      return await _userManager.CheckPasswordAsync(identityUser, loginUser.Password);
    }
  }
}
