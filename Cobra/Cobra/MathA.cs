using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class MathA
    {
        public void add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("--------------This from MathA-----------");
            Console.WriteLine("The result of adding " + a + " and" + b +" is " + result);
        }
    }
}
