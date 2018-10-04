using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRDC.Utilities;

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
            try
            {
                //_connection = new NpgsqlConnection(connectionString);
                //_connection.Open();
            }
            catch (Exception e)
            {
                throw ErrorLaucher.Launch(e);
            }
        }

        private new void CloseConnection()
        {
            try
            {
                //_connection.Dispose();
                //_connection.Close();
            }
            catch (Exception e)
            {
                throw ErrorLaucher.Launch(e);
            }
        }

        public override void Dispose()
        {
            CloseConnection();
            GC.SuppressFinalize(this);
        }
    }
}