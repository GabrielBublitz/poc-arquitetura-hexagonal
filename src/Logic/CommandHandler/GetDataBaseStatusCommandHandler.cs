using Dapper;
using Domain.Adapters;
using Domain.Adapters.DataBse;
using Logic.CommandHandler.Default;
using MediatR;

namespace Logic.CommandHandler
{
    public class GetDataBaseStatusCommandHandler : AbstractCommandHandler, IRequestHandler<GetDataBaseStatusCommand, IList<int>>
    {
        public GetDataBaseStatusCommandHandler(IDBConnnectionProvider DBConnectionFactory, IDBContextFactory DBContextFactory)
            : base(DBConnectionFactory, DBContextFactory)
        { }

        public Task<IList<int>> Handle(GetDataBaseStatusCommand request, CancellationToken cancellationToken)
        {
            NewContext();

            using (DBContext)
            {
                IList<int> response = DBContext.Connection.Query<int>("SELECT 1 AS result").ToList();

                return Task.FromResult(response);
            }
        }
    }
}
