using Domain.Adapters.DataBse;
using System.Data;

namespace Domain.Entities
{
    public class DBContext() : IDBContext
    {
        public IDbTransaction? Transaction { get; set; }

        public IDbConnection? Connection { get; set; }

        public void Dispose() => Connection?.Dispose();
    }
}
