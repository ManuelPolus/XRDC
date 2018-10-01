using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using XRDC.DAL;
using XRDC.Models;

namespace XRDC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataMapper<Model> mapper = new DataMapper<Model>();
            mapper.GetAll();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost
                .CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }
            
    }
}
