using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        uint digit, singleDigits, tenthDigit, hundredsDigit;
        string singleDigitsStr, tenthDigitStr, hundredsDigitStr;

        Console.Write("Input Number:");
        digit = uint.Parse(Console.ReadLine());

        singleDigits = digit % 10;
        tenthDigit = (digit / 10) % 10;
        hundredsDigit = digit / 100;

        switch (hundredsDigit)
        {
            case 1: hundredsDigitStr = "One"; break;
            case 2: hundredsDigitStr = "Two"; break;
            case 3: hundredsDigitStr = "Three"; break;
            case 4: hundredsDigitStr = "Four"; break;
            case 5: hundredsDigitStr = "Five"; break;
            case 6: hundredsDigitStr = "Six"; break;
            case 7: hundredsDigitStr = "Seven"; break;
            case 8: hundredsDigitStr = "Eight"; break;
            case 9: hundredsDigitStr = "Nine"; break;
            default: hundredsDigitStr = "Invalid Hundred Digit"; break;
        }
        switch (tenthDigit)
        {
            case 2: tenthDigitStr = "Twen"; break;
            case 3: tenthDigitStr = "Thir"; break;
            case 4: tenthDigitStr = "Four"; break;
            case 5: tenthDigitStr = "Fif"; break;
            case 6: tenthDigitStr = "Six"; break;
            case 7: tenthDigitStr = "Seven"; break;
            case 8: tenthDigitStr = "Eight"; break;
            case 9: tenthDigitStr = "Nine"; break;
            default: tenthDigitStr = "Invalid Tenth Digit"; break;
        }
        switch (singleDigits)
        {
            case 0: singleDigitsStr = "Zero"; break;
            case 1: singleDigitsStr = "One"; break;
            case 2: singleDigitsStr = "Two"; break;
            case 3: singleDigitsStr = "Three"; break;
            case 4: singleDigitsStr = "Four"; break;
            case 5: singleDigitsStr = "Five"; break;
            case 6: singleDigitsStr = "Six"; break;
            case 7: singleDigitsStr = "Seven"; break;
            case 8: singleDigitsStr = "Eight"; break;
            case 9: singleDigitsStr = "Nine"; break;
            default: singleDigitsStr = "Invalid Digit"; break;
        }

        if (hundredsDigit < 1)
        {
            if (tenthDigit < 1) Console.WriteLine("You have entered: {0}", singleDigitsStr);
            else if (tenthDigit == 1)
            {
                if (singleDigits == 0) Console.WriteLine("You have entered: Ten");
                else if (singleDigits == 1) Console.WriteLine("You have entered: Eleven");
                else if (singleDigits == 2) Console.WriteLine("You have entered: Twelve");
                else if (singleDigits == 3) Console.WriteLine("You have entered: Thirteen");
                else if (singleDigits == 5) Console.WriteLine("You have entered: Fifteen");
                else Console.WriteLine("You have entered: {0}teen", singleDigitsStr);
            }
            else Console.WriteLine("You have entered: {0}ty{1}", tenthDigitStr, singleDigitsStr);
        }
        else
        {
            if (tenthDigit < 1)
            {
                if (singleDigits == 0) Console.WriteLine("You have entered: {0} hundreds", hundredsDigitStr);
                else Console.WriteLine("You have entered: {0} hundreds and {1}", hundredsDigitStr, singleDigitsStr);
            }
            else if (tenthDigit == 1)
            {
                if (singleDigits == 0) Console.WriteLine("You have entered: {0} hundreds and ten", hundredsDigitStr);
                else if (singleDigits == 1) Console.WriteLine("You have entered: {0} hundreds and eleven", hundredsDigitStr);
                else if (singleDigits == 2) Console.WriteLine("You have entered: {0} hundreds and twelve", hundredsDigitStr);
                else if (singleDigits == 3) Console.WriteLine("You have entered: {0} hundreds and thirteen", hundredsDigitStr);
                else if (singleDigits == 5) Console.WriteLine("You have entered: {0} hundreds and fifteen", hundredsDigitStr);
                else Console.WriteLine("You have entered: {0} hundreds and {1}teen", hundredsDigitStr, singleDigitsStr);
            }
            else if (singleDigits == 0) Console.WriteLine("You have entered: {0} hundreds and {1}ty", hundredsDigitStr, tenthDigitStr);
            else Console.WriteLine("You have entered: {0} hundreds and {1}ty{2}", hundredsDigitStr, tenthDigitStr, singleDigitsStr);
        }
    }
}
