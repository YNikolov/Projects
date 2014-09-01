using System;


namespace QuotesInStrings
{
    class Program
    {
        static void Main()
        {            
            string sentenceWithQuotes ="The \"use\" of quotations causes difficulties.";
            string sentenceWithoutQuotes = "The use of quotations causes difficulties.";
            Console.WriteLine(sentenceWithQuotes);
            Console.WriteLine(sentenceWithoutQuotes);
        }
    }
}
