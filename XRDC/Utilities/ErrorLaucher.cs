using System;
using System.Diagnostics;

namespace XRDC.Utilities
{
    /// <summary>
    /// This class should be  used for displaying exceptions without having to add the system diagnostics dependency everywhere
    /// also, it allows to throw it with just ine line of code for both operations
    /// </summary>
    public static class ErrorLaucher
    {

        public static void Launch(Exception ex, bool shouldBeThrown)
        {
            Debug.WriteLine(ex.StackTrace);
            if (shouldBeThrown)
                throw ex;
        }



    }
}
