using ApiNet7WithJwtAndIdentity.Models;
using GestionPracticasProfesionalesUtp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiNet7WithJwtAndIdentity.Services
{
  public class AuthService : IAuthService
  {
    private readonly UserManager<Usuarios> _userManager;
    private readonly IConfiguration _configuration;

    public AuthService(UserManager<Usuarios> userManager, IConfiguration configuration)
    {
      _userManager = userManager;
      _configuration = configuration;
    }

    public async Task<bool> RegisterUserAsync(LoginUser loginUser)
    {
      var identityUser = new Usuarios { UserName = loginUser.UserName, Email = loginUser.UserName };

      var result = await _userManager.CreateAsync(identityUser, loginUser.Password);

      return result.Succeeded;
    }

    public async Task<bool> LoginAsync(LoginUser loginUser)
    {
      var identityUser = await _userManager.FindByNameAsync(loginUser.UserName);

      if (identityUser is null) return false;

      return await _userManager.CheckPasswordAsync(identityUser, loginUser.Password);
    }

    public string GenerateToken(LoginUser loginUser)
    {
      List<Claim> claims = new List<Claim>
      {
        new Claim(ClaimTypes.Email, loginUser.UserName),
        new Claim(ClaimTypes.Role, "ADMIN"),
      };

      SecurityKey securityKey = new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes(_configuration.GetSection("JwtSettings:Key").Value!)
      );

      SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

      var securityToken = new JwtSecurityToken(
        claims: claims,
        expires: DateTime.UtcNow.AddMinutes(60),
        issuer: _configuration.GetSection("JwtSettings:Issuer").Value,
        audience: _configuration.GetSection("JwtSettings:Audience").Value,
        signingCredentials: signingCredentials
      );
      string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);

      return tokenString;
    }
  }
}
