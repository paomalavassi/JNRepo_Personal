using Microsoft.AspNetCore.Mvc;

namespace JN_API_Propio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetMensaje")]
        public IActionResult Get()
        {
            return Ok("TODO BIEN");
        }
    }
}
