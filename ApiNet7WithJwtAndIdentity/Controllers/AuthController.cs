using ApiNet7WithJwtAndIdentity.Models;
using ApiNet7WithJwtAndIdentity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ApiNet7WithJwtAndIdentity.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
      _authService = authService;
    }

    [HttpPost]
    [Route("RegisterUser")]
    public async Task<IActionResult> RegisterUser(LoginUser loginUser)
    {
      return await _authService.RegisterUserAsync(loginUser)
        ? Ok("¡Registro correcto!")
        : BadRequest("¡Registro incorrecto!, algo salió mal");
    }

    [HttpPost]
    [Route("LoginUser")]
    public async Task<IActionResult> LoginUser(LoginUser loginUser)
    {
      if (!ModelState.IsValid) return BadRequest();

      if (await _authService.LoginAsync(loginUser))
      {
        var tokenString = _authService.GenerateToken(loginUser);

        return Ok(tokenString);
      }
      else
      {
        return BadRequest("Credenciales incorrectas");
      }
    }
  }
}
