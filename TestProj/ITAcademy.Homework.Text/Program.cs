using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ITAcademy.Homework.Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFromFile = FileWork.ReadText();
            List<string> sentences = new List<string>();
            sentences = SherlocText.DivideTextToSentences(textFromFile);
            Dictionary<string, int> words = new Dictionary<string, int>();
            words = SherlocText.DivideTextToWords(textFromFile);
            Dictionary<char, int> punctuationSymbols = new Dictionary<char, int>();
            punctuationSymbols = SherlocText.CountPunctuationSymbols(textFromFile);
            string longestSentence = SherlocText.FindLongestSentence(sentences);
            char[] frequentLetter = SherlocText.GetMostFrequentChar(textFromFile);
            FileWork.WriteDownWords(words);
            FileWork.WriteDownInfo(longestSentence, frequentLetter);
        }
    }
}
