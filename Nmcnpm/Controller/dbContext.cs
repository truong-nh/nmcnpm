using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5.Controller
{
    public static class dbContext
    {
        /*static dbContext()
        {
            var dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory");
            string rootDirectory = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin")));
            dataDirectory = Path.Combine(rootDirectory, "");
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
            //Console.WriteLine("xxx"+dataDirectory);
            
        }*/
        public static nmcnpm_teamAKAMEntities db = new nmcnpm_teamAKAMEntities();
    }
}
