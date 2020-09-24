using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class Program
    {
        static void Main(string[] args)
        {
            Exams2 school = new Exams2();
            Exams2 University = new Exams2(200, 90);
            school.physics(99);
            school.chemistry(99);
            school.showresults();
            University.physics(2);
            University.chemistry(90);
            University.showresults();

            Console.Read();
        }
    }
}
