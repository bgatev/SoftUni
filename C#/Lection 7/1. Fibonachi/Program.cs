using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static long Fib(int n)
    {
        long fNumber, fNumber1, fNumberSum;

        fNumber = 1;
        fNumber1 = 1;
        fNumberSum = fNumber + fNumber1;

        if (n == 0) return 1;
        else if (n == 1 || n == 2) return n;
        else
        {
            checked
            {
                for (int i = 0; i < n - 2; i++)
                {
                    fNumber = fNumber1;
                    fNumber1 = fNumberSum;
                    fNumberSum = fNumber + fNumber1;
                }
            }
        }

        return fNumberSum;
    }
    static void Main()
    {
        Console.Write("Input n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}th Fibonachi number is {1}",n, Fib(n));
    }
}
