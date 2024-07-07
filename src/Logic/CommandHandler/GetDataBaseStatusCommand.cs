using MediatR;

namespace Logic.CommandHandler
{
    public class GetDataBaseStatusCommand : IRequest<IList<int>>
    {
        public GetDataBaseStatusCommand() { }
    }
}
