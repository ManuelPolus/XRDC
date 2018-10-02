using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DAL.SelfMadeORMAttempt
{
    public class OracleManager : DbManager
    {
        private const string connectionString = "";
        //private OracleDbConnection _connection;

        public OracleManager()
        {
            OpenConnection();
        }

        private new void OpenConnection()
        {
           // _connection = new OracleConnection(connectionString);
           //_connection.Open();
        }

        private new void CloseConnection()
        {
            //_connection.Dispose();
            //_connection.Close();
        }

        public override void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }
    }
}