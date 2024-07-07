using Domain.Adapters;
using Domain.Adapters.DataBse;

namespace Logic.CommandHandler.Default
{
    public class AbstractCommandHandler(IDBConnnectionProvider DBConnectionFactory, IDBContextFactory DBContextFactory)
    {
        protected IDBContext? DBContext { get; private set; }

        protected IDBContextFactory DBContextFactory { get; private set; } = DBContextFactory;

        protected IDBConnnectionProvider DBConnectionFactory { get; private set; } = DBConnectionFactory;

        public void NewContext()
        {
            DBContext = DBContextFactory.CreateContext(DBConnectionFactory.GetNewConnection());
        }

        public void NewTransation()
        {
            DBContext?.NewTransaction();
        }
    }
}
