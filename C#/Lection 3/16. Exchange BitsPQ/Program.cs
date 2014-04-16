using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        short p, q, k;
        long numberInput, numberDest, maskSource, maskDest, mask, mask0;
        string binaryStringInput, binaryStringResult, binaryMaskS, binaryMaskD, binaryMask, binaryMask0;

        Console.Write("Input Number:");
        numberInput = long.Parse(Console.ReadLine());
        Console.Write("Input Source bit to change:");
        p = short.Parse(Console.ReadLine());
        Console.Write("Input Dest bit to change:");
        q = short.Parse(Console.ReadLine());
        Console.Write("Input Number of bits to change:");
        k = short.Parse(Console.ReadLine());

        binaryStringInput = Convert.ToString(numberInput, 2);
        maskSource = 0;
        maskDest = 0;

        for (int i = 0; i < k; i++)
        {
            maskSource += numberInput & (1 << (p + i));   //get first mask
            maskDest += numberInput & (1 << (q + i));     //get second mask
        }

        mask = (maskSource << (q - p)) | (maskDest >> (q - p));       //get result mask
        mask0 = 0xffffffff & ~(maskSource + maskDest);              //get result mask0

        binaryMaskS = Convert.ToString(maskSource, 2);
        binaryMaskD = Convert.ToString(maskDest, 2);
        binaryMask = Convert.ToString(mask, 2);
        binaryMask0 = Convert.ToString(mask0, 2);

        numberDest = (numberInput & mask0) | mask; //get all not masking bits and put mask over them (exchange required bits)
        binaryStringResult = Convert.ToString(numberDest, 2);

        Console.WriteLine("{0} bits source mask is: {1}", k, binaryMaskS);
        Console.WriteLine("{0} bits dest mask is:   {1}", k, binaryMaskD);
        Console.WriteLine("Result mask is:          {0}", binaryMask);
        Console.WriteLine("Result mask0 is:         {0}", binaryMask0);

        Console.WriteLine("Your number in binary is:{0}", binaryStringInput);
        Console.WriteLine("Result in binary is:     {0}", binaryStringResult);
    }
}
