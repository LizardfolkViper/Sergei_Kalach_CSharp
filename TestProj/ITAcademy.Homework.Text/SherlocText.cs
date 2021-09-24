using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ITAcademy.Homework.Text
{
    class SherlocText
    {
        public static List<string> DivideTextToSentences(string textToSplit)
        {
            List<string> sentencesOfText = new List<string>();
            string[] sentences = Regex.Split(textToSplit, @"(?<=[\.!\?\n])\s+");
            foreach (string sentence in sentences)
            {
                if (!String.IsNullOrEmpty(sentence) && !String.IsNullOrWhiteSpace(sentence))
                {
                    string proceesedSentence = String.Join("", sentence.Where(c => c != '\n' && c != '\r' && c != '\t' && c != '\"'));
                    sentencesOfText.Add(proceesedSentence.Trim('"'));
                }
                else continue;
            }
            return sentencesOfText;
        }

        public static Dictionary<string, int> DivideTextToWords(string textToSplit)
        {
            Dictionary<string, int> wordsOfText = new Dictionary<string, int>();
            Dictionary<string, int> wordsOfTextSorted = new Dictionary<string, int>();
            string[] words = Regex.Split(textToSplit, @"[\W\d_]+");
            foreach (string word in words)
            {
                string proceesedSentence = String.Join("", word.Where(c => c != '\n' && c != '\r' && c != '\t' && c != '\"'));
                if (!wordsOfText.ContainsKey(word))
                {
                    wordsOfText.Add(word, 1);
                }
                else
                {
                    wordsOfText[word] += 1;
                }

            }
            wordsOfTextSorted = wordsOfText.Keys.OrderBy(k => k).ToDictionary(k => k, k => wordsOfText[k]);
            return wordsOfTextSorted;
        }

        public static Dictionary<char, int> CountPunctuationSymbols(string textToSplit)
        {
            Dictionary<char, int> punctuationSymbolsWithCount = new Dictionary<char, int>();
            Regex RegexForPunct = new Regex(@"[^.,!?;:-]+");
            string punctuationArray = RegexForPunct.Replace(textToSplit, "");
            foreach (char punctuationSymbol in punctuationArray)
            {
                if (!punctuationSymbolsWithCount.ContainsKey(punctuationSymbol))
                {
                    punctuationSymbolsWithCount.Add((punctuationSymbol), 1);
                }
                else
                {
                    punctuationSymbolsWithCount[punctuationSymbol] += 1;
                }
            }
            return punctuationSymbolsWithCount;
        }

        public static string FindLongestSentence(List<string> listOfSentences)
        {

            return listOfSentences.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
        }
        public static char[] GetMostFrequentChar(string text)
        {

            Regex RegexForPunct = new Regex(@"[^[A-Za-z]+");
            string textOfLetters = RegexForPunct.Replace(text, "");
            Dictionary<char, int> result = textOfLetters.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return result.Where(x => x.Value == result.Values.Max()).Select(x => x.Key).ToArray();
        }

    }
}
