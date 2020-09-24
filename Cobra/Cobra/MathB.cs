using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class MathB:MathA
    {
        public void subtract(float a, float b)
        {
            float result = a - b;
            Console.WriteLine("--------------This from MathB-----------");
            Console.WriteLine("The result of subracting " + a + " and" + b + " is " + result);
        }
    }
}
