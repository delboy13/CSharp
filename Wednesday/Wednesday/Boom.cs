using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday
{
    class Boom
    {
        int a = 0;
        public void what() {
            int a;
           a = 15;
           this.a = ++this.a;
            Console.WriteLine(++a);
        }
        public void show() {
            Console.WriteLine(a);
        }
    }

}
