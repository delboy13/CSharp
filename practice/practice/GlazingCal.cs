using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class GlazingCal
    {
        static void Main(string[] args)
        {
            //Window glazer programm to return area of glass needed given lenght & height values
            //also returns total length of wood needed for frames given values above
            double width, height, totallength, area;
            string Stringwidth, Stringheight;
            Stringwidth = Console.ReadLine();
            width = double.Parse(Stringwidth);
            Stringheight = Console.ReadLine();
            height = double.Parse(Stringheight);

            totallength = (height + width) * 2;
            area = (height * width) * 2;
            Console.WriteLine(totallength);
            Console.WriteLine(area);


           
        }
    }
}
