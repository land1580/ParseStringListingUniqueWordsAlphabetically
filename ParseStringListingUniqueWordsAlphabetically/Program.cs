using System;
using System.Collections.Generic;
using System.Linq;

namespace ParseStringListingUniqueWordsAlphabetically
{
    class Program
    {
        public static List<string> sentenceList;
        public static List<string> wordList;

        static void Main(string[] args)
        {

            string sentence = "Nyrn and Tyene may have reached King’s Landing by now, she mused, as she settled down crosslegged by the mouth of the cave to watch the falling rain. If not they ought to be there soon. Three hundred seasoned spears had gone with them, over the Boneway, past the ruins of Summerhall, and up the kingsroad. If the Lannisters had tried to spring their little trap in the kingswood, Lady Nym would have seen that it ended in disaster. Nor would the murderers have found their prey. Prince Trystane had remained safely back at Sunspear, after a tearful parting from Princess Myrcella. That accounts for one brother, thought Arianne, but where is Quentyn, if not with the griffin? Had he wed his dragon queen? King Quentyn. It still sounded silly. This new Daenerys Targaryen was younger than Arianne by half a dozen years. What would a maid that age want with her dull, bookish brother? Young girls dreamed of dashing knights with wicked smiles, not solemn boys who always did their duty. She will want Dorne, though. If she hopes to sit the Iron Throne, she must have Sunspear. If Quentyn was the price for that, this dragon queen would pay it. What if she was at Griffin’s End with Connington, and all this about another Targaryen was just some sort of subtle ruse? Her brother could well be with her. King Quentyn. Will I need to kneel to him?";
            wordList = new List<string>();
            sentenceList = new List<string>();
            Console.WriteLine(sentence);
            Console.WriteLine();
            Console.ReadKey();

            char[] sentenceDelimiter = { '.', '?', '!' };
            char[] wordDelimiter = { ',', '.', '?', '!' };
            sentenceList = sentence.Split('.','?','!').ToList();
            wordList = sentence.ToLower().Split( ',', '.', '?', '!', ' ').Distinct().ToList();

            var queryTwo = from word in wordList
                           where word.Count() > 0
                            orderby word
                            select word;
                      
            foreach (var myWord in queryTwo)
            {
                Console.WriteLine("Unique Word: {0}", myWord);
                Console.WriteLine("Count: {0}", myWord.Count());
                Console.WriteLine("Sentences:");
                var query = from sentences in sentenceList
                            where sentences.Contains(myWord)
                            select sentences;

                foreach (var mySent in query)
                {
                    Console.WriteLine(mySent);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
