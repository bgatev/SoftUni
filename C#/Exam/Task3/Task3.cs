using System;
using System.Linq;
using System.Text;

class Task3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++) Console.Write(".");Console.Write("*"); for (int i = 0; i < n / 2; i++) Console.Write(".");
        Console.WriteLine();
        for (int roof = 1, temp=1; roof < n / 2; roof++,temp+=2)
        {
            for (int i = 0; i < n / 2 - roof; i++) Console.Write(".");
            Console.Write("*");
            for (int i = 0; i < temp; i++) Console.Write(".");
            Console.Write("*");
            for (int i = 0; i < n / 2 - roof; i++) Console.Write(".");
            Console.WriteLine();
        }
        for (int i = 0; i < n; i++) Console.Write("*");
        Console.WriteLine();
        
        for (int bottom = 1; bottom < n / 2; bottom++)
        {
            for (int i = 0; i < n / 4; i++) Console.Write(".");
            Console.Write("*");
            if (n % 4 == 1) for (int i = 0; i < n / 2 - 1; i++) Console.Write(".");
            else for (int i = 0; i < n / 2; i++) Console.Write(".");
            Console.Write("*");
            for (int i = 0; i < n / 4; i++) Console.Write(".");
            Console.WriteLine();
        }

        for (int i = 0; i < n / 4; i++) Console.Write(".");
        if (n % 4 == 1) for (int i = 0; i < n / 2 + 1; i++) Console.Write("*");
        else for (int i = 0; i < n / 2 + 2; i++) Console.Write("*");
        for (int i = 0; i < n / 4; i++) Console.Write(".");
        Console.WriteLine();

    }
}

