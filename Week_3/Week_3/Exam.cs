using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Exam
    {
        private int phy, chem, math;
        public int per
        {
            get
            {
                int percentage = totalmarks * 100 / 150;
                Console.WriteLine("Your percentage is: ");
                return percentage;
            }
        }
        public int totalmarks {
            get {
                int total = phy + chem + math;
                Console.WriteLine("Your total marks are: ");
                return total; 
            }
        }


        public int Physics
        {
            set
            {
                if (value >= 0 & value <= 150)
                {
                    phy = value;
                } else
                {
                    Console.WriteLine("Invalid");
                }

            }
            get {
                Console.WriteLine("Results are: ");
                return phy;
            }
        }
        public int Chemistry
        {
            set
            {
                if (value >= 0 & value <= 150)
                {
                    chem = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
            get
            {
                Console.WriteLine("Results are: ");
                return chem;
            }
        }
        
             
            
        }
    }

