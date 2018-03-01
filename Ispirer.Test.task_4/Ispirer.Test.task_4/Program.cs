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
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException();
            }
            DirectoryInfo di_info = new DirectoryInfo(path);
            Scan_folder(di_info, "");
        }

        public static void Scan_folder(DirectoryInfo info, string spaces)
        {
            Console.WriteLine(spaces+info.Name);
            DirectoryInfo[] childrens = info.GetDirectories();
            foreach (var directoryInfo in childrens)
            {
                Scan_folder(directoryInfo, spaces + '\t');

            }

        }
    }
}
