using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispirer.Test.task_5
{
    class Complex_number
    {
        public double A { get; set; }
        public double B { get; set; }


        public Complex_number(double a, double b)
        {
            this.A = a;
            this.B = b;

        }
        public static Complex_number operator +(Complex_number arg1, Complex_number arg2)
        {

            return new Complex_number(arg1.A + arg2.A, arg1.B + arg2.B);
        }

        public static Complex_number operator -(Complex_number arg1, Complex_number arg2)
        {

            return new Complex_number(arg1.A - arg2.A, arg1.B - arg2.B);
        }

        public static Complex_number operator *(Complex_number arg1, Complex_number arg2)
        {

            return new Complex_number(arg1.A*arg2.A-arg1.B*arg2.B, arg1.A * arg2.A + arg1.B * arg2.B);
        }

        public static Complex_number operator /(Complex_number arg1, Complex_number arg2)
        {

            double d=arg2.A*arg2.A+arg2.B*arg2.B;
            if (d == 0)
                return new Complex_number(0, 0);
            double c1 = arg1.A * arg2.A + arg1.B * arg2.B;
            double c2 = arg1.B * arg2.A - arg1.A * arg2.B;
            return new Complex_number(c1/d, c2/d);
        }

        public override string ToString()
        {
            return this.A + "i " + this.B;
        }
    }
}
