using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string fName = "Ivan";
        string mName = "Petrov";
        string lName = "Ivanov";
        long balance = 3242342;
        string bankName = "RaiffeisenBank";
        string IBAN = "BG12RZBB91551010101010";
        string masterCardNumber = "12345678909876543";
        string visaCardNumber = "12345678909876543";
        string maestroCardNumber = "12345678909876543";

        Console.WriteLine("{0} {1} {2} have {3} BGN", fName, mName, lName, balance);
        Console.WriteLine("You are in {0} with IBAN:{1} and cards {2}, {3}, {4}",bankName,IBAN, masterCardNumber, visaCardNumber, maestroCardNumber);
    }
}

