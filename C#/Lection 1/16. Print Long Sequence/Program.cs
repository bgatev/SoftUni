﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        for (int i = 0, j = 1; i < 1000; i++, j *= -1)
        {
            Console.Write("{0} ", (i + 2) * j);
        }
    }
}
