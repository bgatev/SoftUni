using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static long AnyToDec(string inString, int sourceSystem)
    {
        long result = 0;

        for (int i = inString.Length - 1, j = 0; i > -1; i--, j++)
        {
            if ((inString[i] > '9') && (inString[i] < 'G')) result += ((inString[i] - 'A' + 10) * (long)Math.Pow(sourceSystem, j));
            else if ((inString[i] > 'Z') && (inString[i] < 'g')) result += ((inString[i] - 'a' + 10) * (long)Math.Pow(sourceSystem, j));
            else result += ((inString[i] - '0') * (long)Math.Pow(sourceSystem, j));
        }

        return result;
    }

    static void Main()
    {
        string num = string.Empty;
        long resultValue;

        do
        {
            Console.Write("Input less or equal than 32-bit number:");
            num = Console.ReadLine();
        }
        while (num.Length > 32);

        resultValue = AnyToDec(num, 16);

        Console.WriteLine(resultValue);
    }
}
