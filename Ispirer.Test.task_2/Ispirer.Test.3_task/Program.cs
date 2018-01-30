using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispirer.Test.task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook name = Phonebook.Serializ();
            Console.WriteLine("Input surname: ");
            string surmame = Console.ReadLine();

            Entry search =  name.Search_surname(surmame);

            if (search == null)
                Console.WriteLine("Not found!");
            else
                Console.WriteLine(search.Firstname + " " + search.Surname + " " + search.Number);
        }
    }
}
