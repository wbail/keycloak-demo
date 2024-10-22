using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TestKeycloak.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [Authorize]
    [HttpGet("me")]
    public IActionResult Me()
    {
        var claims = HttpContext.User.Claims.ToDictionary(c => c.Type, c => c.Value);

        return Ok(claims);
    }
}
