using ApiGateway.Models;
using ApiGateway.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicroserviceController : ControllerBase
    {
        #region Fields
        private readonly IValuesVervice _valuesVervice;
        private readonly IWeatherService _weatherService;
        #endregion

        #region Constructor
        public MicroserviceController(IValuesVervice valuesVervice, IWeatherService weatherService)
        {
            _valuesVervice = valuesVervice;
            _weatherService = weatherService;
        }
        #endregion

        #region Actions
        // GET: api/<MicroserviceController>/values
        [HttpGet("values")]
        public async Task<ActionResult<Value>> GetValues()
        {
            var result = await _valuesVervice.GetValues();
            return Ok(result);
        }

        // GET api/<MicroserviceController>/weathers
        [HttpGet("weathers")]
        public async Task<ActionResult<WeatherForecast>> GetWeatherForecasts()
        {
            var result = await _weatherService.GetWeatherForecasts();
            return Ok(result);
        }
        #endregion
    }
}
