using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input number:");
        int num = int.Parse(Console.ReadLine());

        int firstDigit = num / 1000;
        int secondDigit = (num / 100) % 10;
        int thirdDigit = (num / 10) % 10;
        int fourthDigit = num % 10;

        int digitsSum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        int reverseNum = int.Parse(fourthDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString());
        int firstPosNum = int.Parse(fourthDigit.ToString() + firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString());
        int exchangePosNum = int.Parse(firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + fourthDigit.ToString());

        Console.WriteLine("{0} {1} {2} {3}",digitsSum,reverseNum,firstPosNum, exchangePosNum);
    }
}
