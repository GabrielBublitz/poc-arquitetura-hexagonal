using System.Data;

namespace Domain.Adapters
{
    public interface IDBConnnectionProvider
    {
        IDbConnection GetNewConnection();
    }
}
