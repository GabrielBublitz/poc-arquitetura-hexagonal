using Domain.Adapters;
using Dapper;
using Domain.Adapters.DataBse;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbCheckController(IDBConnnectionProvider dBConnectionProvider, IDBContextFactory dBContextFactory) : ControllerBase
    {
        private readonly IDBConnnectionProvider DBConnectionProvider = dBConnectionProvider;

        private readonly IDBContextFactory DBContextFactory = dBContextFactory;

        [HttpGet]
        public IEnumerable<int> GetDBConnection()
        {
            using var DBContext = DBContextFactory.CreateContext(DBConnectionProvider.GetNewConnection());

            var response = DBContext.Connection.Query<int>("SELECT 1 AS result");
            return response;
        }
    }
}
