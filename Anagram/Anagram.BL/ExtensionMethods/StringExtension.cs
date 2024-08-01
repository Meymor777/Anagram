using Anagram.Types;
using System.Text;

namespace Anagram.ExtensionMethods
{
    internal static class StringExtension
    {
        public static string ReverseAlphabeticSymbols(this string text)
        {
            if (text == null)
            {
                throw new InvalidParameterException("String has no value assigned");
            }

            var result = new StringBuilder();
            var words = text.Split(' ');

            try
            {
                foreach (var word in words)
                {
                    if (word.Length > 0)
                    {
                        result.Append(ReverseAlphabeticSymbolsInWord(word));
                    }
                    result.Append(" ");
                }

                if (result.Length > 0)
                {
                    result.Remove(result.Length - 1, 1);
                }

                return result.ToString();
            }
            catch
            {
                throw new InvalidParameterException("Failed to process text");
            }
        }

        private static string ReverseAlphabeticSymbolsInWord(string word)
        {
            var result = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                if (!Char.IsLetter(word[i]))
                {
                    result[i] = word[i];
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    result[FindNewIndexForSymbols(result)] = word[i];
                }
            }
            return new string(result);
        }

        private static int FindNewIndexForSymbols(char[] word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] == char.MinValue)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
