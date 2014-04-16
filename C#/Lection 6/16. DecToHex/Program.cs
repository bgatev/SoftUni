using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string ReverseString(string inString)
    {
        string temp = string.Empty;

        for (int i = inString.Length - 1; i > -1; i--) temp += inString[i];

        return temp;
    }

    static string DecToAny(long num, int destSystem)
    {
        string result = string.Empty;

        do
        {
            if ((num % destSystem) <= 9) result += num % destSystem;
            else if ((num % destSystem) <= 15) result += Convert.ToChar((num % destSystem) + 'A' - 10);

            num /= destSystem;
        }
        while (num > 0);
        result = ReverseString(result);

        return result;
    }

    static void Main()
    {
        long num;
        string resultValue = string.Empty;

        Console.Write("Input number:");
        num = long.Parse(Console.ReadLine());


        resultValue = DecToAny(num, 16);

        Console.WriteLine(resultValue);
    }
}
