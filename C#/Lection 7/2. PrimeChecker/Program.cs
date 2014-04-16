using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static bool isPrime(long n)
    {
        int counter = 0;

        for (long i = 2; i < n; i++)
        {
            if (n % i == 0) counter++;
            if (counter == 1) break;
        }

        if ((n < 0) || (counter == 1)) return false;
        else return true;
    }
    static void Main()
    {
        Console.Write("Input n:");
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine("{0} is Prime? {1}", n, isPrime(n));
    }
}
