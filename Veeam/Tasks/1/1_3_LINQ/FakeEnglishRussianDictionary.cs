using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_3_LINQ
{
    public static class FakeEnglishRussianDictionary
    {
        private static Dictionary<string, string> _dictionary = new()
        {
            ["this"] = "эта",
            ["dog"] = "собака",
            ["eats"] = "ест",
            ["too"] = "слишком",
            ["much"] = "много",
            ["vegetables"] = "овощей",
            ["after"] = "после",
            ["lunch"] = "обеда"
        };
        public static string Translate(this string englishWord)
        {
            if (string.IsNullOrEmpty(englishWord))
                return "";
            _dictionary.TryGetValue(englishWord.ToLower(), out var russianWord);
            return russianWord;
        }
    }
}
