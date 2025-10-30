using Microsoft.AspNetCore.Mvc;


namespace Dsw2025Ej14.Api.Controllers;

[ApiController]
[Route("health-check")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Status = "Healthy", Timestamp = DateTime.UtcNow });
    }
}
