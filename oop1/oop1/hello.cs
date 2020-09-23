using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class hello
    {
        static void Main(string[] args)
        {
            //Nationwide C;
            //C = new Nationwide();
            //C.A = 55;
            //C.B = 134;
            //C.C = (C.A * C.B) / 100;
            //C.D = "Hello my friend";
            //Console.WriteLine(C.C);
            //Console.WriteLine(C.D);

            //Maths REF;
            //REF = new Maths();
            //REF.message();
            //Console.Read();

            Operations opt;
            opt = new Operations();
            Maths Eq;
            Eq = new Maths();
            Eq.add(5,5);
            Eq.divide(25,3);



            opt.salarySlip(2000);


            Console.Read();


        }

    }
}
