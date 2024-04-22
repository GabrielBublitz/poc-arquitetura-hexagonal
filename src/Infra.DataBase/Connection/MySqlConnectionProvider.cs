using Domain.Adapters;
using MySql.Data.MySqlClient;
using System.Data;

namespace Infra.DataBase.Connection
{
    public class MySqlConnectionProvider : IDBConnnectionProvider
    {
        public MySqlConnectionProvider() { }

        public IDbConnection GetNewConnection()
        {
            return new MySqlConnection("Server=127.0.0.1;Port=3306;Database=qestudos;Uid=root;Pwd=123456;");
        }
    }
}
