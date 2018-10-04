using System;
using System.Text;
using XRDC.Models.requests;

namespace XRDC.Models
{
    public class Request
    {

        public string ControllerType { get; set; }

        public string Status { get; set; }

        public Options Options { get; set; }

        public override string ToString()
        {
            return JsonUtility.Serialize(this);
        }
    }
}
