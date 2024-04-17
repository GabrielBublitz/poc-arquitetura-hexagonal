using Api.Adapters;
using Dapper;
using Domain.Adapters.DataBse;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbCheckController(IDBConnnectionProvider dBConnectionProvider, IDBContext dbContext) : ControllerBase
    {
        private readonly IDBConnnectionProvider DBConnectionProvider = dBConnectionProvider;

        private readonly IDBContext DBContext = dbContext;

        [HttpGet]
        public IEnumerable<int> GetDBConnection()
        {
            using var dbConnection = DBConnectionProvider.GetNewConnection();

            var response = dbConnection.Query<int>("SELECT 1 AS result");
            return response;
        }
    }
}
