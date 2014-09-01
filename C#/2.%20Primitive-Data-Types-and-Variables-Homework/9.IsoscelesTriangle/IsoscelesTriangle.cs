using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
                  
                char symbol = '©';                
                string space = " ";
                Console.WriteLine("{0}{0}{0}{1}{0}{0}{0}", space, symbol);
                Console.WriteLine("{0}{0}{1}{0}{1}{0}{0}", space, symbol);
                Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", space, symbol);
                Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", space, symbol);
                         
                
                
        }
    }
}
