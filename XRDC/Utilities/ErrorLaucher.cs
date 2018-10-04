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
        /// <exceptions></exceptions>
        public static Exception Launch(Exception ex)
        {
            Debug.WriteLine(ex.StackTrace);
            return ex;
        }

        public static void Display(Exception ex)
        {
            Debug.WriteLine(ex.StackTrace);
        }



    }
}
