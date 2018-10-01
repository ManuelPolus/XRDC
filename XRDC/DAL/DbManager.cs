using System;
using System.Diagnostics;

namespace XRDC.DAL
{
    public class DbManager : IDisposable
    {

        private static string ConnectionString { get; set; }

        public DbManager()
        {
            Open();
        }

        private static void Open()
        {
            try
            {
                //TODO open db connection
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        private static void Close()
        {
            try
            {
                //TODO close db conection
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public T Request<T>()
        {
            T model = default(T);
            QueryBuilder.SELECT("*",model.GetType().Name);
            //TODO make request in DB
            return default(T);
        }

        /// <summary>
        ///     You must pass as arguments the name of the property which the research is based on and the value you want it to have
        /// </summary>
        /// <typeparam name="T"/>
        /// <param name="identifier"/>
        /// <param name="value"/>
        /// <returns></returns>
        public T Request<T>(string identifier,string value)
        {
            T model = default(T);
            string filter = identifier + " = " + value + ";";
            QueryBuilder.SELECT("*", model.GetType().Name,filter);
            return default(T);
        }


        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

    }
}
