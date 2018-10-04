using System;
using XRDC.Models;

namespace XRDC.DAL
{
    public class DataContextSelfMade : IDisposable
    { 
        public DataContextSelfMade()
        {
            InitializeDataSets();        
        }

        //Declaration of data sets

        public DataSet<Resource> Models { get; set; }

        //Here you initialize your DataSets
        private void InitializeDataSets()
        {
            Models = new DataSet<Resource>();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


    }
}
