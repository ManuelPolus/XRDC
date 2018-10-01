using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRDC.Models
{
    public class Request
    {

        public string ControllerType { get; set; }

        public string Status { get; set; }

        public string Options { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{ControllerType: "+ ControllerType+",");
            builder.Append("Status: "+ Status+",");
            builder.Append("Options: "+ Options + "}");

            return builder.ToString();
        }

        public static implicit operator Request(string v)
        {
            throw new NotImplementedException();
        }
    }
}
