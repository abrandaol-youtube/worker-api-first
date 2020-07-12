using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiBackgroundServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"{DateTime.UtcNow:o}");
        }
    }
}
