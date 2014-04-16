using System;

class CompanyData
{
    struct CompanyInfo
    {
        public string cName, address, phoneNumber, faxNumber, webSite;
        public struct Manager
        {
            public string fName, lName, managerPhoneNumber;
            public byte age;
        }
    }
    static void Main()
    {
        CompanyInfo.Manager ManDetails = new CompanyInfo.Manager();
        CompanyInfo Company = new CompanyInfo();

        Console.Write("Input Company Name:");
        Company.cName = Console.ReadLine();
        Console.Write("Input Company Address:");
        Company.address = Console.ReadLine(); ;
        Console.Write("Input Company Phone Number:");
        Company.phoneNumber = Console.ReadLine(); ;
        Console.Write("Input Company Fax Number:");
        Company.faxNumber = Console.ReadLine(); ;
        Console.Write("Input Company Web Site:");
        Company.webSite = Console.ReadLine();

        Console.Write("Input Manager First Name:");
        ManDetails.fName = Console.ReadLine();
        Console.Write("Input Manager Last Name:");
        ManDetails.lName = Console.ReadLine();
        Console.Write("Input Manager Age:");
        ManDetails.age = byte.Parse(Console.ReadLine());
        Console.Write("Input Manager Phone Number:");
        ManDetails.managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company Name:         {0}", Company.cName);
        Console.WriteLine("Company Address:      {0}", Company.address);
        Console.WriteLine("Company Phone Number: {0}", Company.phoneNumber);
        Console.WriteLine("Company Fax Number:   {0}", Company.faxNumber);
        Console.WriteLine("Company Web Site:     {0}", Company.webSite);
        Console.WriteLine("Company Manager Name: {0} {1}", ManDetails.fName, ManDetails.lName);
        Console.WriteLine("Company Manager Age:  {0}", ManDetails.age);
        Console.WriteLine("Manager Phone Number: {0}", ManDetails.managerPhoneNumber);

    }
}
