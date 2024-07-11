using Domain.Adapters;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Infra.DataBase.Connection
{
    public class MySqlConnectionProvider : IDBConnnectionProvider
    {
        public DbConnection DbConnection { get; }

        public MySqlConnectionProvider(string connectionString)
        {
            DbConnection = new MySqlConnection(connectionString);
        }

        public DbConnection GetConnection()
        {
            return DbConnection;
        }
    }
}
