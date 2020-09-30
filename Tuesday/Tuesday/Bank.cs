using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesday
{
    class Bank
    {
        public static int dollar;

        static Bank(){
            dollar = 100;
        }

        public Bank(){
        }
        public void setdollar(int d) {
            dollar = d;
        }
        public void amount(int a) {
            Console.WriteLine("Amount = " + a * dollar);
        }
    }
}
