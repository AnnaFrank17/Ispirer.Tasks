using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispirer.Test.task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Result: ");
            
            Complex_number first = new Complex_number(15, 12);
            Complex_number second = new Complex_number(10, 3);

            Console.WriteLine(first + second);
            Console.WriteLine(first - second);
            Console.WriteLine(first * second);
            Console.WriteLine(first / second);
        }
    }
}
