using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseStringListingUniqueWordsAlphabetically
{
    class Program
    {
        public static List<string> sentenceList;
        public static List<string> wordList;

        static void Main(string[] args)
        {
 //           string paragraph = "Nyrn and Tyene may have reached King’s Landing by now, she mused, as she settled down crosslegged by the mouth of the cave to watch the falling rain. If not they ought to be there soon. Three hundred seasoned spears had gone with them, over the Boneway, past the ruins of Summerhall, and up the kingsroad. If the Lannisters had tried to spring their little trap in the kingswood, Lady Nym would have seen that it ended in disaster. Nor would the murderers have found their prey. Prince Trystane had remained safely back at Sunspear, after a tearful parting from Princess Myrcella. That accounts for one brother, thought Arianne, but where is Quentyn, if not with the griffin? Had he wed his dragon queen? King Quentyn. It still sounded silly. This new Daenerys Targaryen was younger than Arianne by half a dozen years. What would a maid that age want with her dull, bookish brother? Young girls dreamed of dashing knights with wicked smiles, not solemn boys who always did their duty. She will want Dorne, though. If she hopes to sit the Iron Throne, she must have Sunspear. If Quentyn was the price for that, this dragon queen would pay it. What if she was at Griffin’s End with Connington, and all this about another Targaryen was just some sort of subtle ruse? Her brother could well be with her. King Quentyn. Will I need to kneel to him?";
 //           Console.WriteLine(paragraph);
            /*           char[] sentenceDelimiter = { '.', '?', '!' };                    //removed ' ', ','
                       char[] wordDelimiter = { ' ', ',' };
                       string[] uniqueSentence = paragraph.Split(sentenceDelimiter);
                       string[] uniqueWords = paragraph.Split(wordDelimiter);
                       int numUniqWords = 0;
                       Array.Sort(uniqueWords);
                       Console.WriteLine();
                       Console.ReadKey();

                       foreach (var word in uniqueWords.Distinct())
                       {
                           numUniqWords++;
                           Console.WriteLine($"{word}");
                           Console.ReadLine();
                           Console.WriteLine("Count: {0}", numUniqWords);
                           string a = uniqueSentence.Contains(uniqueWords.Distinct(numUniqWords));
                           Console.WriteLine("Sentence: {0}", a);
                           Console.WriteLine();
                       }
                       Console.ReadKey();
           */

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


            string sentence = "Nyrn and Tyene may have reached King’s Landing by now, she mused, as she settled down crosslegged by the mouth of the cave to watch the falling rain. If not they ought to be there soon. Three hundred seasoned spears had gone with them, over the Boneway, past the ruins of Summerhall, and up the kingsroad. If the Lannisters had tried to spring their little trap in the kingswood, Lady Nym would have seen that it ended in disaster. Nor would the murderers have found their prey. Prince Trystane had remained safely back at Sunspear, after a tearful parting from Princess Myrcella. That accounts for one brother, thought Arianne, but where is Quentyn, if not with the griffin? Had he wed his dragon queen? King Quentyn. It still sounded silly. This new Daenerys Targaryen was younger than Arianne by half a dozen years. What would a maid that age want with her dull, bookish brother? Young girls dreamed of dashing knights with wicked smiles, not solemn boys who always did their duty. She will want Dorne, though. If she hopes to sit the Iron Throne, she must have Sunspear. If Quentyn was the price for that, this dragon queen would pay it. What if she was at Griffin’s End with Connington, and all this about another Targaryen was just some sort of subtle ruse? Her brother could well be with her. King Quentyn. Will I need to kneel to him?";
            wordList = new List<string>();
            sentenceList = new List<string>();
            Console.WriteLine(sentence);
            string sentence2 = sentence;
            string paragraph = sentence;
            Console.WriteLine();
            Console.ReadKey();

            char[] sentenceDelimiter = { '.', '?', '!' };
            char[] wordDelimiter = { ' ', ',', '.', '?', '!' };


            sentenceList = sentence.Split('.','?','!').ToList();

            var query = from sentences in sentenceList
                        orderby sentences
                        select sentences;

            foreach (var elementSentence in query)
            {
                Console.WriteLine(elementSentence);
            }
            
            Console.ReadKey();

            wordList = sentence.ToLower().Split().Distinct().ToList();

            var queryTwo = from word in wordList
                        orderby word
                        select word;
                      
            foreach (var element in queryTwo)
            {
                Console.WriteLine("Unique Word: {0}", element);
                Console.WriteLine("Count: {0}", element.Count());
                Console.WriteLine("Sentences:");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();

            wordList = sentence.ToLower().Split().ToList();

            var queryThree = from word in wordList
                         let duplicate = findDuplicate(word)
                         where duplicate.Equals(false)
                         select word;

            foreach (var duplElement in queryThree)
                Console.WriteLine(duplElement);                                    

            Console.ReadKey();

            string[] allSentences = paragraph.Split(new char[] { '.', '?', '!' });
           
            string[] wordMatch = { "younger" };

            var sentenceQuery = from oneSentence in allSentences
                                let w = oneSentence.Split(new char[] { '.', '?', '!', ' ', ',' },
                                StringSplitOptions.RemoveEmptyEntries)
                                where w.Distinct().Intersect(wordMatch).Count() == wordMatch.Count()
                                select oneSentence;
            foreach (string str in sentenceQuery)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }

        public static bool findDuplicate(string word)
        {
            bool isDuplicate = false;
            int numOfDuplicates = 0;

            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].Equals(word))
                    numOfDuplicates++;
            }

            if (numOfDuplicates > 1)
                isDuplicate = true;

            return isDuplicate;
        }
    }
}
