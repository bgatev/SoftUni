using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object result = firstWord + " " + secondWord;
        string greeting = (string)result;

        Console.WriteLine(greeting);
    }
}

