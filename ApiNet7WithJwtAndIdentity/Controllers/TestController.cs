using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiNet7WithJwtAndIdentity.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class TestController : ControllerBase
  {
    [HttpGet]
    public string Get() => "do you have access to me?";
  }
}
