using MicroserviceWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroserviceWebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        #region Fields
        private readonly ILogger<ValuesController> _logger;

        private readonly IEnumerable<Value> _values;
        #endregion

        #region Constructor
        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
            _values = new List<Value>
            {
                new Value
                {
                    Id = 1,
                    Name ="Value 1"
                },
                new Value
                {
                    Id = 2,
                    Name ="Value 2"
                },
                   new Value
                {
                    Id = 3,
                    Name ="Value 3"
                },   new Value
                {
                    Id = 4,
                    Name ="Value 4"
                },   new Value
                {
                    Id = 5,
                    Name ="Value 5"
                }
            };
        }
        #endregion

        #region Actions
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<Value>> Get()
        {
            return Ok(_values);
        }
        #endregion
    }
}
