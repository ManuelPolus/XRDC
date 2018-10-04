using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace XRDC.Models
{
    public static class JsonUtility
    {

        public static string Serialize(object o)
        {
            try
            {
                return JsonConvert.SerializeObject(o);
            }
             catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                throw new JsonException("json converison problem [object -> string], check formats");
            }
        }

        public static T Deserialize<T>(string objectAsString)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(objectAsString);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                throw new JsonException("json converison problem [string -> object], check formats");
            }
        }



    }
}
