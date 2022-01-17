using ApiGateway.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiGateway.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();
    }
}
