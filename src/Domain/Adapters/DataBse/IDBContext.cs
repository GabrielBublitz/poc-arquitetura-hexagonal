using System.Data;

namespace Domain.Adapters.DataBse
{
    public interface IDBContext : IDisposable
    {
        IDbConnection? Connection { get; }

        IDbTransaction? Transaction { get; }
    }
}
