using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Shop T = new Shop();
            //T.details(38,150);

            //Finance F = new Finance();

            //Console.WriteLine("Your net pay will b " + F.tax(2000,20));
            //Console.WriteLine("The tax you paid was " + F.tax() + "%");
            //Console.WriteLine("you paid in tax " + F.tax(2000));

            //Exam J = new Exam();

            //J.Physics = 135;
            //J.Chemistry = 149;

            //Console.WriteLine(J.Physics);
            //Console.WriteLine(J.Chemistry);
            ////Console.WriteLine(J.per);
            //Console.WriteLine(J.totalmarks);
            //Nationwide X = new Nationwide();
            //HR t = new HR();
            //t.Login();

            //int day = 2;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Switch day is Monday");
            //        break;
            //    case (2):
            //        Console.WriteLine("Switch day is Tuesday");
            //        break;
            //    default:
            //        Console.WriteLine("Not found");
            //        break;
            //}

            //int [] salaries ={200,300,400,500};
            //int i = 0;

            //for (int i; i < salaries[i].length; i++)
            //{
            //    Console.WriteLine(salaries[p]);
            //}

            int[] nums = { 27, 36, 92, 42, 71 };
            Console.WriteLine("The highest number is : " + nums.Max());
            Console.WriteLine("The Average of the list of numbers is : " + nums.Average());
            Console.WriteLine("The lowest number is : " + nums.Min());

            if (nums.Average() > 50)

            {
                Console.WriteLine("We have higher than 50 average");
            }
            else
            {
                Console.WriteLine("This average was not higher than 50");
            }

        }
    }
}
