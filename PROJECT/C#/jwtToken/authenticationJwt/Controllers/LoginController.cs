using Microsoft.AspNetCore.Mvc;

namespace authenticationJwt.Controllers;

[ApiController]
[Route("api/v1/login")]
public class LoginController : ControllerBase
{
    private readonly ILogger<LoginController> _logger;
    private readonly LoginService _service;

    public LoginController(ILogger<LoginController> logger, LoginService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost]
    public IActionResult Login(LoginRequestModel account){
        var response = _service.Login(account);
        return Ok(response);
    }
}
