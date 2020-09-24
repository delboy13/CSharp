using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class Exam
    {
        private int phy, chem, math;
        private int invalidmarks, failed;
        public void physics(int p)
        {
            if (p >= 0 && p <= 150)
            {
                phy = p;
                if (p<60)
                {
                    failed = 1;
                }
            }
            else
            {
                invalidmarks = -1;
                Console.WriteLine("Invalid physics marks, someone cheated");
            }
        }

        public void chemistry(int c)
        {
            if (c >= 0 && c <= 150)
            {
                chem = c;
                if (c < 60)
                {
                    failed = 1;
                }
            }
            else
            {
                Console.WriteLine("Invalid chemistry marks, cheat");
            }
        }
        public void maths(int m)
        {
            if (m >= 0 && m <=150)
            {
                math = m;
                if (m < 60)
                {
                    failed = 1;
                }
            }
            else
            {
                invalidmarks = -1;
                Console.WriteLine("Invalid maths marks, Wrong");
            }
        }
                public void showresults()
        {
                    float total, per;
                    total = phy + chem;
                    per = total * 100 / 450;
            if (invalidmarks == 0)
            {
                if (failed == 0)
                {
                    Console.WriteLine("Your total marks are: " + total);
                    Console.WriteLine("Your percentage is: " + per);
                }
                else {
                    Console.WriteLine("you have failed the exam");
                }
            
                
            }


        }
            }


}
