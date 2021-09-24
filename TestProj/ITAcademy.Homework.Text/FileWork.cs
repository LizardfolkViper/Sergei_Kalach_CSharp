using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Homework.Text
{
    class FileWork
    {
        public static string ReadText()
        {
            string folderPath = @"D:\Coding";
            string textFromFileRaw = File.ReadAllText($@"{folderPath}\sample.txt");
            return textFromFileRaw;
        }

        public static void WriteDownWords(Dictionary<string, int> wordsList)
        {
            string path = @"D:\Coding\WordUsageList.txt";
            using (StreamWriter writingStream = new StreamWriter(path, false))
            {
                foreach (KeyValuePair<string, int> wordWithUsage in wordsList)
                {
                    writingStream.WriteLine($"Word: {wordWithUsage.Key}, Used: {wordWithUsage.Value}");
                }
            }
        }

        public static void WriteDownInfo(string longestSentence, char[] frequentLetterArray)
        {
            char frequentLetter = frequentLetterArray[0];
            string path = @"D:\Coding\InfoList.txt";
            using (StreamWriter writingStream = new StreamWriter(path, false))
            {
                writingStream.WriteLine($"Longest sentence (tecnically): {longestSentence}");
                writingStream.WriteLine($"Most frequent used letter (case sensetive): {frequentLetter}");
            }
        }
    }
}
