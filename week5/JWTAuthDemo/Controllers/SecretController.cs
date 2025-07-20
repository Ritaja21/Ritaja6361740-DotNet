using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SecretController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetSecret()
    {
        var username = User.Identity?.Name;
        return Ok($"Welcome {username}, you accessed a protected endpoint!");
    }
}
