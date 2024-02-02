using Microsoft.AspNetCore.Mvc;

namespace ApiAgenciaBancariaGraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgenciaBancariaController : ControllerBase
    {
        private readonly ILogger<AgenciaBancariaController> _logger;

        public AgenciaBancariaController(ILogger<AgenciaBancariaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public bool Get()
        {
            return true;
        }
    }
}
