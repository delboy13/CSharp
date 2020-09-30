using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesday
{
    class Numbers
    {
        public void highest()
        {
            int[] numbers = { 72, 92, 88, 47 };

            
            int highestnumber = numbers[1];
            int sec = numbers[1];
            for (int i = numbers[1]; i <= numbers.Length; i++)
            { if (highestnumber > numbers[i])
                {
                    highestnumber = numbers[i];
                    if (numbers[i] < highestnumber)
                    {
                        sec = numbers[i];
                    }
                }
                Console.WriteLine(highestnumber);
            }

        }
    }
}
