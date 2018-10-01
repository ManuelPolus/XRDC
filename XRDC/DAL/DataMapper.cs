using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace XRDC.DAL
{
    public class DataMapper<T> where T : class
    {

        private DbContextOptions<DataContext<T>> _options;

        public DataMapper()
        {
            _options = new DbContextOptions<DataContext<T>>();
        }


        public List<T> GetAll()
        {
            using (DataContext<T> context = new DataContext<T>())
            {
                try
                {
                    return context.Data.ToList();
                }
                catch(InvalidOperationException ex)
                {
                    Debug.WriteLine("/!\\_______________/!\\");
                    Debug.WriteLine(ex.StackTrace);
                    return null;
                }
                
            }
        }

        public T GetById(int id)
        {
            using (DataContext<T> context = new DataContext<T>(_options))
            {                
                return context.Data.FirstOrDefault(t => Int32.Parse(t.GetType().GetProperty("Id").ToString()) == id);
            }
        }


    }
}
