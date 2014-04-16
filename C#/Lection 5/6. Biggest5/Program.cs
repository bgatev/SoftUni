using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int Num1, Num2, Num3, Num4, Num5;

        Console.Write("Input first number:");
        Num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        Num2 = int.Parse(Console.ReadLine());
        Console.Write("Input third number:");
        Num3 = int.Parse(Console.ReadLine());
        Console.Write("Input fourth number:");
        Num4 = int.Parse(Console.ReadLine());
        Console.Write("Input fifth number:");
        Num5 = int.Parse(Console.ReadLine());

        if (Num1 > Num2)
        {
            if (Num3 < Num2)
            {
                if (Num4 > Num5)
                {
                    if (Num4 > Num1) Console.WriteLine("The biggest number is {0}", Num4);
                    else Console.WriteLine("The biggest number is {0}", Num1);
                }
                else
                {
                    if (Num5 > Num1) Console.WriteLine("The biggest number is {0}", Num5);
                    else Console.WriteLine("The biggest number is {0}", Num1);
                }
            }
            else if (Num3 < Num1)
            {
                if (Num4 > Num5)
                {
                    if (Num4 > Num1) Console.WriteLine("The biggest number is {0}", Num4);
                    else Console.WriteLine("The biggest number is {0}", Num1);
                }
                else
                {
                    if (Num5 > Num1) Console.WriteLine("The biggest number is {0}", Num5);
                    else Console.WriteLine("The biggest number is {0}", Num1);
                }
            }
            else
            {
                if (Num4 > Num5)
                {
                    if (Num4 > Num1) Console.WriteLine("The biggest number is {0}", Num4);
                    else Console.WriteLine("The biggest number is {0}", Num3);
                }
                else
                {
                    if (Num5 > Num1) Console.WriteLine("The biggest number is {0}", Num5);
                    else Console.WriteLine("The biggest number is {0}", Num3);
                }
            }

        }
        else
        {
            if (Num3 < Num1)
            {
                if (Num4 > Num5)
                {
                    if (Num4 > Num1) Console.WriteLine("The biggest number is {0}", Num4);
                    else Console.WriteLine("The biggest number is {0}", Num2);
                }
                else
                {
                    if (Num5 > Num1) Console.WriteLine("The biggest number is {0}", Num5);
                    else Console.WriteLine("The biggest number is {0}", Num2);
                }
            }
            else if (Num3 < Num2)
            {
                if (Num4 > Num5)
                {
                    if (Num4 > Num1) Console.WriteLine("The biggest number is {0}", Num4);
                    else Console.WriteLine("The biggest number is {0}", Num2);
                }
                else
                {
                    if (Num5 > Num1) Console.WriteLine("The biggest number is {0}", Num5);
                    else Console.WriteLine("The biggest number is {0}", Num2);
                }
            }
            else
            {
                if (Num4 > Num5)
                {
                    if (Num4 > Num1) Console.WriteLine("The biggest number is {0}", Num4);
                    else Console.WriteLine("The biggest number is {0}", Num3);
                }
                else
                {
                    if (Num5 > Num1) Console.WriteLine("The biggest number is {0}", Num5);
                    else Console.WriteLine("The biggest number is {0}", Num3);
                }
            }
        }
    }
}
