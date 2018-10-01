using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
                Debug.WriteLine(e.StackTrace);
            }
            throw new Exception("you really fucked up...");
        }

        public void Add(T objectToAdd)
        {
            try
            {
                Set.Add(objectToAdd);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
        }

        public List<T> All()
        {
            return Set ?? throw new Exception("");
        }

        private DataSet<T> Get()
        {
            using (DbManager dbManager = new DbManager())
            {
                Set = dbManager.Request<List<T>>();
            }
            return this;
        }


    }
}
