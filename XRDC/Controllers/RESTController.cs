using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRDC.DemandManagement;

namespace XRDC.Controllers
{
    
    [ApiController]
    [Route("api/resources")]
    public class RESTController : ControllerBase
    {
        [Route("api/resources/get")]
        public string Get()
        {
            string result ="";

            try
            {
                //request
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return result;

        }

        [Route("api/resources/post/{demand}")]
        public bool Post(string demand)
        {
            try
            {
                var request = DemandAnalyzer.AnalyzeAndExecute(demand);
                // obey command
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }



    }
}
