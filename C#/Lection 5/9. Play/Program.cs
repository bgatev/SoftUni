using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Please enter an int: ");
                    int inputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", inputInt + 1);
                break;
            case 2: Console.Write("Please enter a double: ");
                    double inputDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", inputDouble + 1);
                break;
            case 3: Console.Write("Please enter a string: ");
                    string input = Console.ReadLine();
                    Console.WriteLine("{0}*", input);
                break;
            default: Console.WriteLine("Invalid Choice"); 
                break;
        }
    }
}
