using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string copyrightSym = "\u00a9";
        Console.OutputEncoding = Encoding.Unicode;
        
        Console.WriteLine("   {0}", copyrightSym);
        Console.WriteLine("  {0} {0}", copyrightSym);
        Console.WriteLine(" {0} {0} {0} ", copyrightSym);
        Console.WriteLine("{0} {0} {0} {0}", copyrightSym);
    }
}

