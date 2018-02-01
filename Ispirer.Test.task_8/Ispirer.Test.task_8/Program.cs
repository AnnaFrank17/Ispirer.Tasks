using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ispirer.Test.task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            var assembly = Assembly.LoadFile(path);

            foreach (var group in assembly.GetTypes().GroupBy(i=>i.Namespace))
            {
                Console.WriteLine("namespase " + group.First().Namespace);

                foreach (var type_g in group)
                {
                    Console.WriteLine(type_g.FullName);

                }

            }

        }
    }
}
