﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class HR:Nationwide
    {
        public override void Login()
        {
            Console.WriteLine("Login");
        }
        public override void Logout()
        {
            Console.WriteLine("Log out please");
        }
    }
}
