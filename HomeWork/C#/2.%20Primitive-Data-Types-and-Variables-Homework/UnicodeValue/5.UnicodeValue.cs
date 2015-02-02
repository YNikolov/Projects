using System;


namespace UnicodeValue
{
    class UnicodeValue
    {
        static void Main()
        {
            
            byte number = 72;
            char symbol = Convert.ToChar(number);
            Console.WriteLine("The symbol representation of '{0}' is: {1}", number, symbol);
        }
    }
}
