using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Operations
    {
        //public int No1, No2;
        //public void message()
        //{
        //    Console.WriteLine("Hello");
        //    Console.WriteLine("My Amigos");
        
        //public void Add(int x, int y)
        //{
        //    int result = x + y;
        //    Console.WriteLine("the result is " + (x +y));
        //}

    public void salarySlip(int salary) {
        float tax, net;
        if (salary >= 2000)
        {
            tax = salary * 20 / 100;
        }
        else
        {
            tax = salary * 10 / 100;
        }

        net = salary - tax;
        Console.WriteLine("----------------");
        Console.WriteLine("your salary is : " + salary);
        Console.WriteLine("Your tax is: " + tax);
        Console.WriteLine("Your net income is: " + net);
    }
    }
}
