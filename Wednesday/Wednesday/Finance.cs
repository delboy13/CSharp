using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday
{
    class Finance
    {
        public void Tax(int salary, int absent) {
            float tax = 0;
            float net = 0;
            if (absent > 10)
            {
                NBSException E = new NBSException();
                throw E;
            }
            else {
                tax = salary * 20 / 100;
                net = salary - tax;
                Console.WriteLine("The salary tax is " + salary);
                Console.WriteLine("The total tax is " + tax);
                Console.WriteLine("The total net is " + net);
            }
        }
    }
}
