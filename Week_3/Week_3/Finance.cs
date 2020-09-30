using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Finance
    {
        public int tax()
        {
          return 20;
        }
        public float tax(int salary)

        {
            float t = (float)salary * tax() / 100;
            return t;
        }
        public float tax(int salary, int t)

        {
            float Net = (float) salary -((float)salary * t / 100);
            return Net;
        }
    }
}
