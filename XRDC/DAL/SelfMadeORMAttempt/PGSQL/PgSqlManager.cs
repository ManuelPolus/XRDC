using Npgsql;
using System;

namespace XRDC.DAL
{
    public class PgSqlManager : DbManager
    {

        private const string connectionString = "";
        private NpgsqlConnection _connection;

        public PgSqlManager()
        {
            OpenConnection();
        }

        private new void OpenConnection()
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        private new void  CloseConnection()
        {
            _connection.Dispose();
            _connection.Close();
        }

        public override  void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }
    }
}