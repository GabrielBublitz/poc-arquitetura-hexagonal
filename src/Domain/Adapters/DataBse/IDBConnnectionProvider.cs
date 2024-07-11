using System.Data.Common;

namespace Domain.Adapters
{
    public interface IDBConnnectionProvider
    {
        DbConnection DbConnection { get; }

        DbConnection GetConnection();
    }
}
