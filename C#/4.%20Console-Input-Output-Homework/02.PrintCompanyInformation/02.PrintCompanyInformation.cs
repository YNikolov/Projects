using System;

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            int phoneNumber = int.Parse(Console.ReadLine());
            int faxNumber = int.Parse(Console.ReadLine());
            string webSite = Console.ReadLine();
            string manager = Console.ReadLine();
            Console.WriteLine("Name: {0}\nAddress: {1}\nPhone number: {2}\nFax number: {3}\nWeb site: {4}\nManager: {5}"
                ,name, address, phoneNumber, faxNumber, webSite, manager );

        }
    }
}
