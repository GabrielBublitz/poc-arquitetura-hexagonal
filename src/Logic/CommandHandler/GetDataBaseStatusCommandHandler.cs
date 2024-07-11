using Dapper;
using Domain.Adapters;
using Domain.Adapters.DataBse;
using Logic.CommandHandler.Default;
using MediatR;

namespace Logic.CommandHandler
{
    public class GetDataBaseStatusCommandHandler(IDBConnnectionProvider DBConnectionFactory, IDBContextFactory DBContextFactory) 
        : AbstractCommandHandler(DBConnectionFactory, DBContextFactory), IRequestHandler<GetDataBaseStatusCommand, IList<int>>
    {
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
