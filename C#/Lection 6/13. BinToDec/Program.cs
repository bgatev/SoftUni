using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static long BinToDec(string inString)
    {
        long result = 0;

        for (int i = inString.Length - 1, j = 0; i > -1; i--, j++) result += ((inString[i] - '0') * (int)Math.Pow(2, j));

        return result;
    }

    static string BinaryInvert(string inString)
    {
        string result = string.Empty;

        for (int i = 0; i < inString.Length; i++)
        {
            if (inString[i] == '0') result += 1;
            else result += 0;
        }

        return result;
    }

    static void Main()
    {
        string num = string.Empty;
        long decValue = 0;
        int sign = 1;

        do
        {
            Console.Write("Input less or equal than 32-bit binary number:");
            num = Console.ReadLine();
        }
        while (num.Length > 32);


        if (num.Length < 32) decValue = BinToDec(num);
        else
        {
            if (num[0] == '1') sign = -1;       //get num sign
            num = num.Substring(1);             //get num without sign

            num = BinaryInvert(num);            //invert to get positive num
            decValue = BinToDec(num) + 1;
        }

        Console.WriteLine(sign * decValue);
    }
}
