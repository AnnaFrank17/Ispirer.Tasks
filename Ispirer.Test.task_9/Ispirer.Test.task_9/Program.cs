using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ispirer.Test.task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_file = args[0];
            string output_file = args[1];

            string input_encoding = args[2];
            string output_encoding = args[3];

            string file_content;

            Console.WriteLine(input_file + " "+ output_file + " " + input_encoding + " " + output_encoding);

            using (StreamReader fs = new StreamReader(new FileStream(input_file, FileMode.OpenOrCreate), Encoding.GetEncoding(input_encoding)))
            {

                file_content = fs.ReadToEnd();
            }

            using (StreamWriter sw = new StreamWriter(new FileStream(output_file, FileMode.OpenOrCreate), Encoding.GetEncoding(output_encoding)))
            {
                sw.Write(file_content);
            }
        }
    }
}
