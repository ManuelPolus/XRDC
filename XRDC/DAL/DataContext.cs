using System;
using XRDC.Models;

namespace XRDC.DAL
{
    public class DataContext : IDisposable
    { 
        public DataContext()
        {
            InitializeDataSets();        
        }

        //Declaration of data sets

        public DataSet<Model> Models { get; set; }

        //Here you initialize your DataSets
        private void InitializeDataSets()
        {
            Models = new DataSet<Model>();

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
