#Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.The words in paragraph are case-insensitive and the answer should be returned in lowercase.
#Example 1:
#Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
#Output: "ball"
#Explanation: "hit" occurs 3 times, but it is a banned word. "ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
#Note that words in the paragraph are not case sensitive, that punctuation is ignored (even if adjacent to words, such as "ball,"), and that "hit" isn't the answer even though it occurs more because it is banned.


using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace MostCommonWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = { "hit" };
            string commonWord = MostCommonWord(paragraph, banned);
            Console.WriteLine("Most frequent word is : {0}", commonWord);
            Console.WriteLine();
        }
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            try
            {
                //remove punctuation characters, convert to lower case, split into words array 
                paragraph = Regex.Replace(paragraph, @"[^\w\d\s]", "");
                string lparah = paragraph.ToLower();
                string[] textSplit = lparah.Split(" ");

                //create Dic to collect word and it's respective counts
                IDictionary<string, int> wordcount = new Dictionary<string, int>();

                //iterate within words array
                //add 1 to count if word exits
                //intialize a key: words ; value:1
                foreach (string s in textSplit)
                {
                    bool keyExists = wordcount.ContainsKey(s.Trim());
                    if (keyExists)
                    {
                        wordcount[s]++;
                    }
                    else
                    {
                        wordcount.Add(s, 1);
                    }
                }

                //remove banned words from Dic
                foreach (string s in banned)
                {
                    wordcount.Remove(s);
                }


                string word = wordcount.Keys.First();
                int count = wordcount.Values.Max();
                //find max count and it's respective count.
                foreach (KeyValuePair<string, int> temp in wordcount)
                {
                    if (temp.Value == count)
                    {
                        word = temp.Key;
                    }
                }
                return word;
            }
            catch (Exception)
            {

                throw;
            }
        }
