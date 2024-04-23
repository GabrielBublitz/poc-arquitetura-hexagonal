using Domain.Entities;
using System.Data.Common;

namespace Logic.CommandHandler
{
    public class AbstractCommandHandler(DbConnection connection)
    {
        protected DbConnection Connection = connection;

        public DBContext NewContext()
        {
            return new DBContext(Connection);
        }

        public void NewTransation()
        {
            Connection.Open();
            Connection.BeginTransaction();
        }
    }
}
