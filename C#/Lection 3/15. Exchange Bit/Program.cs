using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        long numberInput, numberDest, maskSource, maskDest, mask;
        string binaryStringInput, binaryStringResult, binaryMaskS, binaryMaskD, binaryMask;

        Console.Write("Input Number:");
        numberInput = long.Parse(Console.ReadLine());

        binaryStringInput = Convert.ToString(numberInput, 2);


        maskSource = (numberInput & (1 << 3)) + (numberInput & (1 << 4)) + (numberInput & (1 << 5));    //get first mask
        maskDest = (numberInput & (1 << 12)) + (numberInput & (1 << 13)) + (numberInput & (1 << 14));   //get second mask

        mask = (maskSource << 9) | (maskDest >> 9);       //get result mask

        binaryMaskS = Convert.ToString(maskSource, 2);
        binaryMaskD = Convert.ToString(maskDest, 2);
        binaryMask = Convert.ToString(mask, 2);

        numberDest = (numberInput & 0xffff8fc7) | mask; //get all not masking bits and put mask over them (exchange required bits)
        binaryStringResult = Convert.ToString(numberDest, 2);

        Console.WriteLine("3-5 bits mask is:   {0}", binaryMaskS);
        Console.WriteLine("12-14 bits mask is: {0}", binaryMaskD);
        Console.WriteLine("Result mask is:     {0}", binaryMask);

        Console.WriteLine("Your binary is:     {0}", binaryStringInput);
        Console.WriteLine("Result in binary is:{0}", binaryStringResult);
    }
}
