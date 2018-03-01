using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class anyTest
    {
        public void MyProc(int a)
        {
            int typePresent = 2;
            if ((typePresent & 2) == 2)
            {
                a = a + 15;
            }
            Console.WriteLine(a);
        }

        public void StrDecl()
        {
            string[] GG = new string[5];
            GG[1] = "Grille1";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(GG[i]);
            }
        }
     

            public string TestFormatFunction()
            {
                return $"{12:D}";
            }

            public string TestFormatFunction1()
            {
                return $"{12:D} {"coucou"}";
            }

        public void DirDefault()
        {
            int i;
            char Bourre;
            StringBuilder St = new StringBuilder("someStringss");
            label0 :
            i = St.Length-1;


            Bourre = 's';
            while (i > 0)
            {
                if (St[i] == Bourre )
                {
                    Console.Write(St[i]);
                    St[i] = ' ';
                }
                else
                  goto  label0;
                i--;
            }

        }

        public void HrMajTableUtilisees()
        {
            string TextEx;
            try
            {
                TextEx = "5";
                Console.WriteLine(TextEx);
            }
            catch (Exception E)
            {
                
                throw;
            }
        }

        public void Test1()
        {
            Boolean a;
            Boolean b;
            a = true;
            b = false;
            if (a ^ b == true)
            {
                Console.WriteLine("a^b");
            }
            if (a != b)
            {
                Console.WriteLine("a!=b");
            }
            if (!a)
            {
                Console.WriteLine("!a");
            }
            if (a || b)
            {
                Console.WriteLine("a||b");
            }
            if (!(a && b))
            {
                Console.WriteLine("a&&b");
            }
        }

        public void Test2()
        {
            string i;
            string i1 ;
            string r;
            string di;
            string dwr;
            int s;
           
            i1 = Convert.ToString(2, 2);
            i = Convert.ToString(1, 2);
            r = Convert.ToString(Convert.ToInt32(i,2) + Convert.ToInt32(i1, 2), 2);

            if (r != Convert.ToString(3, 2))
            {
                throw new Exception("must be $3");
            }
            di = Convert.ToString(123, 2);
            dwr = Convert.ToString(Convert.ToInt32(di, 2) * 65535 , 2);
            s = Convert.ToInt32(dwr, 2); ;
            if (s != Convert.ToInt32(di,2))
            {
                throw new Exception("it must be $123");
            }


        }

        public void TestPosFunction()
        {
            const String sqlResult = "SELECT * FROM DETABLES!";
            string sql;
            int i;
            
            i = sqlResult.IndexOf("*", StringComparison.Ordinal);

            if (i != 8)
            {
                throw new Exception("''*'' should be at position 8");
            }
            sql = sqlResult;

            if (sql[i] == '*')
            {
                Console.WriteLine(sql);
            }
            else
            {
                throw new Exception($"''*'' expected at position {i}");
            }
        }

    }
}
