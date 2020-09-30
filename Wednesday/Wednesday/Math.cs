using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday
{
    class Math
    {
        public void division(int no1, int no2)
        {
            int result =0 ;

            try
            {
                result = no1 / no2;
                Console.WriteLine("The result is " + result);
            }
            catch (DivideByZeroException D2)
            {
                Console.WriteLine("---------------------");
                Console.Write(D2.ToString()); //reference variable allows us to see detais of the exception
                Console.WriteLine("You cannot divide by Zero amigo, try again or go back to school");
                Console.WriteLine("No offence");
                Console.WriteLine("---------------------");
            }
            
        }
        public void ArrayProcessing(int i)
        {
            int[] num = { 2, 3 };
            try
            {
                Console.WriteLine("the value at loction " + i + "is" + num[i]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Cannot access the location in array");
            }
        }
    }
}
