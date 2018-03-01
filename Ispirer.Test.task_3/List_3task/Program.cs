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
            list.myEvent += Event_size;

            for (; ; )
            {
                Console.WriteLine("Select: ");
                Console.WriteLine("1 - Add ");
                Console.WriteLine("2 - Show ");
                Console.WriteLine("3- GetElementByIndex ");

                string num = Console.ReadLine(); ;

                Choice(num, list);
            }

        }
        public static void Choice(string ch, MyList<int> list)
        {
            switch (ch)
            {
                case "1":
                    Console.WriteLine("Enter objcet to add : ");
                    int v;
                    while (!int.TryParse(Console.ReadLine(), out v))
                    {
                       // Console.Clear();
                        Console.WriteLine("Not int, try again");
                    }

                    list.add(v);
                    break;

                case "2":
                    list.Show();
                    break;

                case "3": list.GetElement();

                    break;
            }
        }

        public static void Event_size()
        {
            Console.WriteLine("Size was changed!");

        }
    }
}
