using Oracle.ManagedDataAccess.Client;
using System;
using System.Diagnostics;

namespace XRDC.DAL
{
    public class DbManager : IDisposable
    {

        private const string _connectionString = "10.10.11.206";
        private static OracleConnection _oracleConnection { get; set; }
        private static OracleCommand _cmd;


        public DbManager()
        {
            Open();
        }

        private static void Open()
        {
            try
            {
                _oracleConnection = new OracleConnection(_connectionString);
                _oracleConnection.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
        }

        private static void Close()
        {
            try
            {
                if (_oracleConnection != null)
                {
                    _oracleConnection.Dispose();
                    _oracleConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public DataSet<T> SelectAll<T>()
        {
            T model = default(T);
            string sql = QueryBuilder.SELECT("*", model.GetType().Name);
            _cmd = new OracleCommand(sql, _oracleConnection);
            _cmd.ExecuteReader();
            //TODO make request in DB
            return default(DataSet<T>);
        }

        /// <summary>
        ///     You must pass as arguments the name of the property which the research is based on and the value you want it to have
        /// </summary>
        /// <typeparam name="T"/>
        /// <param name="identifier"/>
        /// <param name="value"/>
        /// <returns></returns>
        public T SelectAllWhere<T>(string identifier, string value)
        {
            T model = default(T);
            string filter = identifier + " = " + value + ";";
            QueryBuilder.SELECT("*", model.GetType().Name, filter);
            return default(T);
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

    }
}
