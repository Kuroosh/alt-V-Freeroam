using System;
using System.Collections.Generic;
using System.Text;

namespace Freeroam.Core
{
    public static class Debug
    {
        public static void CatchExceptions(string FunctionName, Exception ex)
        {
            Console.WriteLine("[EXCEPTION " + FunctionName.ToUpper() + "] " + ex.Message);
            Console.WriteLine("[EXCEPTION " + FunctionName.ToUpper() + "] " + ex.StackTrace);
        }

    }
}
