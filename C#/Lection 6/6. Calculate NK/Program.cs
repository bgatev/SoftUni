using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n, k;
        long kResult = 1, nResult = 1;
        
        Console.Write("Input n:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Input k:");
        k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) nResult *= i;
        for (int i = 1; i <= k; i++) kResult *= i;

        Console.WriteLine("{0}! / {1}! is: {2}", n, k, nResult/kResult);
    }
}
