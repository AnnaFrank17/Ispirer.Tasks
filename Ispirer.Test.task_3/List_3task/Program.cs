using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_3task
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> list = new MyList<int>();
            list.myEvent += event_size;

            for (; ; )
            {
                Console.WriteLine("Select: ");
                Console.WriteLine("1 - Add ");
                Console.WriteLine("2 - Show ");
                Console.WriteLine("3- GetElementByIndex ");

                string num = Console.ReadLine(); ;

                choice(num, list);
            }

        }
        public static void choice(string ch, MyList<int> list)
        {
            switch (ch)
            {
                case "1":
                    Console.WriteLine("Enter objcet to add : ");
                    string p = Console.ReadLine();
                    int v = Convert.ToInt32(p);

                    list.add(v);
                    break;

                case "2":
                    list.show();
                    break;

                case "3": list.getelement();

                    break;
            }
        }

        public static void event_size()
        {
            Console.WriteLine("Size was changed!");

        }
    }
}
