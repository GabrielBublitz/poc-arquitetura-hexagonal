using System.Data;

namespace Domain.Adapters
{
    public interface IMySqlAdapter
    {
        public IDbConnection GetNewConnection();
    }
}
