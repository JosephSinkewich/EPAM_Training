using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EpamTrnHw05
{
    class Program
    {
        const int COUNT_REPLACEMENTS = 25000;
        const int MIN_WORD_LENGTH = 5;

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"goncharov_ivan-obyknovennaja_istorija.txt", Encoding.Default);
            string[] words = text.Split();

            Dictionary<string, string> wordReplacements = new Dictionary<string, string>();
            Dictionary<string, string> wordReplacementsReverse = new Dictionary<string, string>();
            char replaceSymbol = Convert.ToChar(2000);

            foreach (string word in words)
            {
                if (wordReplacements.Count > COUNT_REPLACEMENTS)
                {
                    break;
                }

                if (word.Length >= MIN_WORD_LENGTH && !wordReplacements.ContainsKey(word))
                {
                    wordReplacements.Add(word, replaceSymbol.ToString());
                    wordReplacementsReverse.Add(replaceSymbol.ToString(), word);
                    replaceSymbol++;
                }
            }

            foreach (string word in wordReplacements.Keys)
            {
                text = text.Replace(word, wordReplacements[word]);
            }

            File.WriteAllText(@"pack.txt", text, Encoding.Default);

            foreach (string symbol in wordReplacementsReverse.Keys)
            {
                text = text.Replace(symbol, wordReplacementsReverse[symbol]);
            }

            File.WriteAllText(@"unpack.txt", text, Encoding.Default);
        }
    }
}
