using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesday
{
    class Strings
    {
        public void Printvertical(string msg)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine(msg.Substring(i, 1));
            }
        }
        public void Wordcount(string msg)
        {
            int space = 0;
            int i = 0;
            for (; i < msg.Length; i++)
            {
                if (msg.Substring(i, 1) == " ")
                {
                    space++;
                }
            }
            Console.WriteLine("Words: " + (space + 1));
        }
        public void Verticalwords(string message)
        {

            for (int i = 0; i < message.Length; i++)
            {
                if (message.Substring(i, 1) == " ")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(message.Substring(i, 1));
                }
            }

        }
        public void Vertical2(string msg)
        {
            string word = "";
            int i = msg.Length - 1;
            for (; i >= 0; i--)
            {
                if (msg.Substring(i, 1) == " ")
                {
                    Console.WriteLine(word);
                    word = " ";
                }
                else
                {
                    word = msg.Substring(i, 1) + word;
                }

            }
            Console.WriteLine(word);


        }

    }
}


