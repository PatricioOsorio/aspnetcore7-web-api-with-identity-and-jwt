using ApiNet7WithJwtAndIdentity.Models;

namespace ApiNet7WithJwtAndIdentity.Services
{
  public interface IAuthService
  {
    Task<bool> RegisterUserAsync(LoginUser loginUser);
    Task<bool> LoginAsync(LoginUser loginUser);
    string GenerateToken(LoginUser login);
  }
}