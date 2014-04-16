using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int count = 0;
        string wordToFind = Console.ReadLine();
        string input = Console.ReadLine();
        string[] inputString = input.Split(new char[] { ' ',',' ,'!','(',')','\"','/','\\','@','#','$','%','^','&','*','-','+','<','>','?','.'}, StringSplitOptions.RemoveEmptyEntries);

        wordToFind = wordToFind.ToLower();

        for (int i = 0; i < inputString.Length; i++)
        {
            inputString[i] = inputString[i].ToLower();
            if (inputString[i] == wordToFind) count++;
        }

        Console.WriteLine(count);
    }
}
