using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class MathD:MathC
    {
        public void divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("--------------This from MathD-----------");
            Console.WriteLine("The result of dividing " + a + " by" + b + " gives you " + result );
        }
        new public void add(int a, int b)
        
        {
            int result = a + b;
            Console.WriteLine("@@@@@@ This has come from MathsA && has been overriden in MathsD@@@@@@@@");
            Console.WriteLine("The result is now showing as " + result);
        }
    }
}
