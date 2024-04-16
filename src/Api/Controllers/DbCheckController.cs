using Api.Adapters;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbCheckController(IDBConnnectionAdapter dBConnnection) : ControllerBase
    {
        private readonly IDBConnnectionAdapter dBConnnection = dBConnnection;

        [HttpGet]
        public IEnumerable<int> GetDBConnection()
        {
            using var connection = dBConnnection.GetNewConnection();

            var response = connection.Query<int>("SELECT 1 AS result");

            return response;
        }
    }
}
