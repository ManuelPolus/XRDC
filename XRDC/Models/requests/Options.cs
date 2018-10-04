using System.Collections.Generic;

namespace XRDC.Models.requests
{
    public class Options
    {

        public int Id { get; set; }

        public List<string> Params {get;set;}

        public override string ToString()
        {
            return JsonUtility.Serialize(this);
        }

    }
}
