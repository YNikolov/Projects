using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {            
            int numberOne = new int(); 
            double numberTwo = new double();
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            numberOne += 3;
            numberTwo += 6.8d;
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);            
        }
    }
}
