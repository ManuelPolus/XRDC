using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using XRDC.DemandManagement.SubControllers;
using XRDC.Models;

namespace XRDC.DemandManagement
{
    public class DemandAnalyzer
    {

        public static bool AnalyzeAndExecute(string demand)
        {
            Request request = SplitRequest(demand);
          
            Type type = Type.GetType("XRDC.DemandManagement.SubControllers." + request.ControllerType);
            string status = request.Status;
            string options = request.Options;

            object specializedcontroller = Activator.CreateInstance(type);
            SubController controller = (SubController)SubController.Build(specializedcontroller);

            return controller.ExecuteRequest(status,options);
        }

        private static Request SplitRequest(string demand)
        {
            try
            {
                Request r = new Request();
                r = JsonConvert.DeserializeObject<Request>(demand);
                return r;
            }
            catch(Exception e)
            {
                throw new JsonSerializationException();
            }            
        }

    }
}
