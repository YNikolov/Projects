using System;


namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {           
            byte a = 5;
            byte b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a ^= b;
            b ^= a;
            a ^= b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
