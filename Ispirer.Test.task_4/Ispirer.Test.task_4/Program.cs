using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ispirer.Test.task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = args.Length ==  0
                ? Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                : args[0];
            DirectoryInfo di_info = new DirectoryInfo(path);
            scan_folder(di_info, "");
        }

        public static void scan_folder(DirectoryInfo info, string spaces)
        {
            Console.WriteLine(spaces+info.Name);
            DirectoryInfo[] childrens = info.GetDirectories();
            foreach (var directoryInfo in childrens)
            {
                scan_folder(directoryInfo, spaces + '\t');

            }

        }
    }
}
