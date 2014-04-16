using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input your birtday: (dd.mm.yyyy) ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Now you are {0} years old",DateTime.Now.Year - birthDate.Year);
        Console.WriteLine("After 10 years you will be {0} years old",DateTime.Now.Year + 10 - birthDate.Year);
    }
}

