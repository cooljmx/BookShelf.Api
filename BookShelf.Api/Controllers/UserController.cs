using BookShelf.Api.Requests.User;
using BookShelf.Api.Security;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILoginService _loginService;

    public UserController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request)
    {
        var loginResponse = await _loginService.LoginAsync(request);

        if (loginResponse == null)
            return Unauthorized();

        return Ok(loginResponse);
    }
}