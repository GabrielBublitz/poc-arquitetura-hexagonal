using System.Data;

namespace Api.Adapters
{
    public interface IDBConnnectionProvider
    {
        IDbConnection GetNewConnection();
    }
}
