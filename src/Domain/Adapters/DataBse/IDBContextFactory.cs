using System.Data.Common;

namespace Domain.Adapters.DataBse
{
    public interface IDBContextFactory
    {
        IDBContext CreateContext(DbConnection connection);
    }
}
