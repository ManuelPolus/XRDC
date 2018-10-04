    using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using XRDC.Utilities;

namespace XRDC.DAL
{
    public class DataSet<T>
    {

        private List<T> Set { get; set; }
        private T TypeOfSet { get; set; }
        protected static DbManager _dbManager;

        public DataSet()
        {
            Get();
        }

        public T Find(T searchedObject)
        {

            try
            {
                return Set.FirstOrDefault<T>(t => t.Equals(searchedObject));
            }
            catch (Exception e)
            {
               throw ErrorLaucher.Launch(new Exception("you really fucked up..."));
            }
            
        }

        public void Add(T objectToAdd)
        {
            try
            {
                Set.Add(objectToAdd);
            }
            catch (Exception e)
            {
                throw ErrorLaucher.Launch(e);
            }
        }

        public List<T> All()
        {
            return Set ?? throw new Exception("DataSet had a problem returning it's data");
        }

        private DataSet<T> Get()
        {
            using (PgSqlManager pgsqlManager = new PgSqlManager())
            {
                // Set = dbManager.SelectAll<List<T>>();
            }
            return this;
        }


        private void SaveChanges()
        {
           
        }


    }
}
