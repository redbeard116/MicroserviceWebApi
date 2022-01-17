using ApiGateway.Extensions;
using ApiGateway.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiGateway.Services
{
    public class WeatherService : IWeatherService
    {
        #region Fields
        private readonly HttpClient _httpClient;
        #endregion

        #region Constructor
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        #endregion

        #region IValuesVervice
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            var responce = await _httpClient.GetAsync("/api/v1/WeatherForecast");
            return await responce.ReadContentAs<IEnumerable<WeatherForecast>>();
        }
        #endregion
    }
}
