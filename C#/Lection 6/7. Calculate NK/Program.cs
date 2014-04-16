using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n, k;
        BigInteger kResult = 1, nResult = 1,nkResult = 1;

        Console.Write("Input n:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Input k:");
        k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) nResult *= i;
        for (int i = 1; i <= k; i++) kResult *= i;
        for (int i = 1; i <= (n-k); i++) nkResult *= i;

        BigInteger knkResult = (kResult * nkResult);
        double result = (double)nResult / (double) knkResult;
        Console.WriteLine("{0}! / ({1}! * {2}!) is: {3}", n, k, (n-k), result);
    }
}
