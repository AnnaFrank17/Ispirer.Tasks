using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ispirer.Test.task_7
{
    class Program
    {
        static void Main(string[] args)
        {

            byte[] byte_array;
            if (!File.Exists("bytes.txt"))
            {
                throw new FileNotFoundException();
            }
            using (FileStream fs = new FileStream("bytes.txt", FileMode.Open))
            {
                byte_array = new byte[fs.Length];

                fs.Read(byte_array, 0, byte_array.Length);

               
            }

            Array.Sort(byte_array);

            using (FileStream fw = new FileStream("writer_sort_bytes.txt", FileMode.OpenOrCreate))
            {
                fw.Write(byte_array, 0, byte_array.Length);
            }

        }
    }
}
