using ApiGateway.Extensions;
using ApiGateway.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiGateway.Services
{
    public class ValuesVervice : IValuesVervice
    {
        #region Fields
        private readonly HttpClient _httpClient;
        #endregion

        #region Constructor
        public ValuesVervice(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        #endregion

        #region IValuesVervice
        public async Task<IEnumerable<Value>> GetValues()
        {
            try
            {
                var responce = await _httpClient.GetAsync("/api/v1/Values");
                return await responce.ReadContentAs<IEnumerable<Value>>();
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
