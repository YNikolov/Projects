using System;

namespace _09.IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            sbyte usersChoice = sbyte.Parse(Console.ReadLine());

            switch (usersChoice)
            { 
                case 1:
                    Console.Write("Please enter a int: ");
                    int one = int.Parse(Console.ReadLine());
                    Console.WriteLine(one + 1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double two = double.Parse(Console.ReadLine());
                    Console.WriteLine(two + 1);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string three = Console.ReadLine();
                    Console.WriteLine(three + "*");
                    break;
                    
                default:
                    break;
            }
        }
    }
}
