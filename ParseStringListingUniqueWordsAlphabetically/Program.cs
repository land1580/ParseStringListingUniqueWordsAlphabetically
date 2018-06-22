using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseStringListingUniqueWordsAlphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "I am a string, ok man? What do you want me to do.";
            Console.WriteLine(paragraph);
            Console.WriteLine();
            char[] delimiters = { ' ', '.', ',', '?', '!' };
            string[] uniqueWords = paragraph.Split(delimiters);

            foreach (var word in uniqueWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
