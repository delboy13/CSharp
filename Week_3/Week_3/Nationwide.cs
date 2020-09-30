using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    abstract class Nationwide
    {
        abstract public void Login();

        abstract public void Logout();

        public void msg()
        {
            Console.WriteLine("Hello");
        }
    }
   
}
