using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n;
        BigInteger nFact = 1, n1Fact = 1, n2Fact = 1;

        Console.Write("Input N:");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) nFact *= i;
        n1Fact = nFact * (n + 1);
        for (int i = 1; i <= 2 * n; i++) n2Fact *= i;

        Console.WriteLine("{0}th Catalan number is {1}", n, n2Fact / (n1Fact * nFact));
    }
}
