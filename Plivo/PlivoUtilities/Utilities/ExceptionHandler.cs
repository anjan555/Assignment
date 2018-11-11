using System;
using System.Collections.Generic;
using System.Text;


namespace Plivo.SeleniumCore.Utilities
{
    public static class ExceptionHandler
    {
        public static String CurrentException = null;

        public static void Handle(Exception e)
        {
            CurrentException = e.Message;

        }

        public static void Handle(Exception e, String m)
        {
            CurrentException = m + '\n' + e.Message;

        }

        public static void Reset()
        {
            CurrentException = null;
        }
    }
}
