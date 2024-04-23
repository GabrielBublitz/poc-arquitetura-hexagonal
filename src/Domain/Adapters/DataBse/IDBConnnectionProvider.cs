using System.Data.Common;

namespace Domain.Adapters
{
    public interface IDBConnnectionProvider
    {
        DbConnection GetNewConnection();
    }
}
