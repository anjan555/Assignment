using System;
using System.Collections.Generic;
using System.Text;

namespace Plivo.SeleniumCore.Helpers
{
    public static class Helper
    {
        
        public static string CreateFolder(string componentName)
        {
            var _dayFolderName = componentName + DateTime.Now.ToString("yyyyMMddhhmmss");
            return System.IO.Directory.CreateDirectory(_dayFolderName).FullName;
             
        }
    }
}
