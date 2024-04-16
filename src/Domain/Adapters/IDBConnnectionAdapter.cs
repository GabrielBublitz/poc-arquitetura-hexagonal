using System.Data;

namespace Api.Adapters
{
    public interface IDBConnnectionAdapter
    {
        public IDbConnection GetNewConnection();
    }
}
