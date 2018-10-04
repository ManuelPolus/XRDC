using Npgsql;
using System;
using XRDC.Utilities;

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
            try
            {
                _connection = new NpgsqlConnection(connectionString);
                _connection.Open();
            }
            catch(Exception e)
            {
                throw ErrorLaucher.Launch(e);
            }
        }

        private new void  CloseConnection()
        {
            try
            {
                _connection.Dispose();
                _connection.Close();
            }
            catch (Exception e)
            {
                throw ErrorLaucher.Launch(e);
            }
        }

        public override  void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }
    }
}