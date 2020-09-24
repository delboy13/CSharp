using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class MathC:MathB
    {
        public void multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("--------------This from MathC-----------");
            Console.WriteLine("The result of multiplying " + a + " and" + b + " is " + result);
        }
        new public void subtract(float a, float b)
        {
            float result = a - b;
            Console.WriteLine("!!!!!!!!!! This has come from MathsB && has been overriden in MathsC !!!!!!!");
            Console.WriteLine("The result is now showing as " + result);
        }
    }
}
