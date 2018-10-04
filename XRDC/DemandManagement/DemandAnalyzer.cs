using System;
using XRDC.DemandManagement.SubControllers;
using XRDC.Models;
using XRDC.Utilities;

namespace XRDC.DemandManagement
{
    public class DemandAnalyzer
    {

        public static bool AnalyzeAndExecute(string demand)
        {
            Request request = SplitRequest(demand);

            Type type = Type.GetType("XRDC.DemandManagement.SubControllers." + request.ControllerType);
            string status = request.Status;
            string options = "";
            if (request.Options != null)
            {
                 options = request.Options.ToString();
            }


            object specializedcontroller = Activator.CreateInstance(type);
            SubController controller = (SubController)SubController.Build(specializedcontroller);

            return controller.ExecuteRequest(status, options);
        }

        private static Request SplitRequest(string demand)
        {
            try
            {
                Request r = new Request();
                r = JsonUtility.Deserialize<Request>(demand);
                return r;
            }
            catch (Exception e)
            {
                throw ErrorLaucher.Launch(e);
            }
        }

    }
}
