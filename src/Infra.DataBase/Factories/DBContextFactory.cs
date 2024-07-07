using Domain.Adapters.DataBse;
using Domain.Entities;
using System.Data.Common;

namespace Infra.DataBase.Factories
{
    internal class DBContextFactory : IDBContextFactory
    {
        public DBContextFactory() { }

        public IDBContext CreateContext(DbConnection connection)
        {
            return new DBContext(connection);
        }
    }
}
