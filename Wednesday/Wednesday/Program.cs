using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math M = new Math();
            //Math2 X = new Math2();

            //M.division(4, 0);
            ////M.ArrayProcessing(2);
            ////X.division(4, 0);
            //try
            //{
            //    X.Division2(4, 0);
            //    M.division(4, 0);
            //}
            //catch (DivideByZeroException x)
            //{
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine("Main method exception catcher? Division2");
            //    Console.WriteLine(x.ToString());
            //    Console.WriteLine("---------------------");
            //}
            //Finance F = new Finance();
            //F.Tax(200,2);

            //try
            //{
            //    F.Tax(20000, 11);
            //}
            //catch (NBSException R) {
            //    Console.WriteLine("your fired and salary is gone");
            //}

            Boom b = new Boom();
            b.what();
            b.show();
            Console.Read();
        }
    }
}
