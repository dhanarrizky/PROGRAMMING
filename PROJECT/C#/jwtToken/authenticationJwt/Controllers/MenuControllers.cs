using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authenticationJwt.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/Menu")]
public class MenuControllers : ControllerBase
{
    private readonly ILogger<MenuControllers> _logger;
    private readonly MenuService _service;

    public MenuControllers(ILogger<MenuControllers> logger, MenuService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public IActionResult Menu(){
        
        var response = _service.GetMenu();
        return Ok(response);
    }
}
