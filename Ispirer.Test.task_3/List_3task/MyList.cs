using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_3task
{

    class MyList <T>
    {
        List<T> arra = new List<T>();

        public delegate void MyDelegat();

        public event MyDelegat myEvent;

        public void add( T item)
        {
            

            arra.Add(item);

            myEvent.Invoke();
        }

        public void show()
        {
            for (int i = 0; i < arra.Count(); i++)
            {
                T item = arra[i];
                Console.Write(item + " ");               
            }
            Console.WriteLine();
        }

        public void getelement()
        {
            Console.WriteLine("Enter index : ");

            string s = Console.ReadLine();
            int k = Convert.ToInt32(s);

            for (int i = 0; i < arra.Count(); i++)
            {               
                if (i == k)
                    Console.WriteLine(arra[i]);
            }

        }
       
        }
}
