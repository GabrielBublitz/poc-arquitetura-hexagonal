using Domain.Adapters;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Infra.DataBase.Connection
{
    public class MySqlConnectionProvider : IDBConnnectionProvider
    {
        public MySqlConnectionProvider() { }

        public DbConnection GetNewConnection()
        {
            return new MySqlConnection("Server=127.0.0.1;Port=3306;Database=qestudos;Uid=root;Pwd=123456;");
        }
    }
}
