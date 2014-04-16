using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string firstWord = "The \"use\" of quotations causes difficulties.";
        string secondWord = "The " + @"""use" + @""" of quotations causes difficulties.";


        Console.WriteLine("{0} {1}", firstWord, secondWord);
    }
}

