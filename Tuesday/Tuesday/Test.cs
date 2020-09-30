using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesday
{
    class Test
    {
        public void countword(string msg)
        {
            string line = msg;
            string[] words = line.Split(new[] { " "}, StringSplitOptions.None);
            string word = "";
            int ctr = 0;

            foreach (string s in words)
            {
                if (s.Length > 0)
                {
                    word = s;
                    ctr = s.Length;
                }
            } Console.WriteLine("The longest word in the string sentence is : " + word);
            
        }
    }
}

/// <summary>
/// //////////
/// </summary>
