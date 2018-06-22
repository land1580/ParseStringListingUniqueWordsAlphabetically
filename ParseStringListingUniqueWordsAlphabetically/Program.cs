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
            string paragraph = "I am a string, ok man? What do you a want me to do I.";
            Console.WriteLine(paragraph);
            char[] delimiters = { ' ', '.', ',', '?', '!' };
            string[] uniqueWords = paragraph.Split(delimiters);
            Array.Sort(uniqueWords);
            
            foreach (var word in uniqueWords.Distinct())
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
