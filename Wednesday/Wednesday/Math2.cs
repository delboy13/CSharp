using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday
{
    class Math2
    {
        public void division(int a, int b) {
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException D3)
            {
                Console.WriteLine("Cannot divide by Zero");
            }
        }

        public void Division2(int no1, int no2) {
            int result = no1 / no2;
            Console.WriteLine("result is " + result);
        }

    }
}
