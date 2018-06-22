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
            string paragraph = "I am a string, ok man? What do you a want why what ok i me to do I.";
            Console.WriteLine(paragraph);
            char[] delimiters = { ' ', '.', ',', '?', '!' };
            string[] uniqueWords = paragraph.Split(delimiters);
            Array.Sort(uniqueWords);

/*            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in uniqueWords)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();  */

                        foreach (var word in uniqueWords.Distinct())
                        {
                            Console.WriteLine($"{word}");
                        }
                        Console.ReadKey();   
        }
    }
}
