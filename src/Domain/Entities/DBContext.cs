using Domain.Adapters.DataBse;
using System.Data.Common;

namespace Domain.Entities
{
    public class DBContext(DbConnection connection) : IDBContext
    {
        public DbConnection Connection = connection;

        public DbTransaction? Transaction;

        public void Dispose()
        {
            Connection?.Dispose();
        }

        public void Commit()
        {
            Transaction?.Commit();
        }

        public void RollBack()
        {
            Transaction?.Rollback();
        }

        public void NewTransaction()
        {
            Connection.Open();

            Transaction = Connection.BeginTransaction();
        }
    }
}
