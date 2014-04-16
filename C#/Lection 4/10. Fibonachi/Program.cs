using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double fNumber, fNumber1, fNumberSum;

        fNumber = 0;
        fNumber1 = 1;
        fNumberSum = fNumber + fNumber1;

        Console.Write("Input number n:");
        int n = int.Parse(Console.ReadLine());

        if (n == 1) Console.WriteLine("0");
        else if (n == 2) Console.WriteLine("0 1");
        else
        {
            Console.Write("{0} ", fNumber);
            Console.Write("{0} ", fNumber1);
            Console.Write("{0} ", fNumberSum);

            checked
            {
                for (int i = 0; i < n - 3; i++)
                {
                    fNumber = fNumber1;
                    fNumber1 = fNumberSum;
                    fNumberSum = fNumber + fNumber1;
                    Console.Write("{0:N0} ", fNumberSum);
                }
            }
        }
    }
}
