using Logic.CommandHandler;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbCheckController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator Mediator = mediator;

        [HttpGet]
        public IEnumerable<int> GetDBConnection()
        {
            var cmd = new GetDataBaseStatusCommand();
            var result = Mediator.Send(cmd).Result;

            return result;
        }
    }
}
