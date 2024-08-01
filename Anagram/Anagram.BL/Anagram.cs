using Anagram.ExtensionMethods;

namespace Anagram.BL
{
   public class Anagram
    {
        public static string ReverseText(string text)
        {
            return text.ReverseAlphabeticSymbols();
        }
    }
}
