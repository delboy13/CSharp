using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Maths
    {
//add, sub, div, mul

            public void add(int x, int y) {
            int result = x + y;
            Console.WriteLine("the result of adding is " + (x + y));
        }
        public void minus(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("the result of subtracting is " + (x - y));
        }
        public void divide(int x, int y)
        {
            float result = x / y;
            Console.WriteLine("the result of dividing is " + (x / y));
        }
        public void multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("the result of multiplying is " + (x * y));
        }
    }
    }

