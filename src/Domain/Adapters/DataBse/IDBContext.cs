using System.Data.Common;

namespace Domain.Adapters.DataBse
{
    public interface IDBContext : IDisposable
    {
        public DbConnection Connection { get; }

        public DbTransaction? Transaction { get; }

        void Commit();

        void RollBack();

        void NewTransaction();
    }
}
