using System.Data;

namespace Domain.Adapters
{
    public interface IDBConnnectionAdapter
    {
        public IDbConnection GetNewConnection();
    }
}
