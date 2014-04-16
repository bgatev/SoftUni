using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        
        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine("{0} -> {1}",i,(char)i);    
        }
    }
}

