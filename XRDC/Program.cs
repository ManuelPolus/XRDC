using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using XRDC.DemandManagement;

namespace XRDC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string demand = "{" +
                "\"ControllerType\" : \"LightController\"," +
                " \"Status\" : \" ON\"," +
                " \"Options\" : \" none\"" +
                "}";

            string demandMusic = "{" +
                "\"ControllerType\" : \"MusicController\"," +
                " \"Status\" : \" ON\"," +
                " \"Options\" : \" gudule bourlet\"" +
                "}";

            DemandAnalyzer.AnalyzeAndExecute(demandMusic);

            CreateWebHostBuilder(args).Build().Run();

           

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
