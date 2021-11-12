using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_3_LINQ
{
    public static class TaskExtensions
    {
        #region Task1
        public static string GetNameByDelimetersWithoutFirstThree(this IEnumerable<IName> objects, char delimeter)
        {
            if (objects == null)
                return null;

            return string.Join(delimeter, objects.Skip(3).Select(e => e.Name));
        }
        #endregion

        #region Task2
        public static IEnumerable<IName> FilterByNameLengthAndPosition(this IEnumerable<IName> objects)
        {
            if (objects == null)
                return null;
            var counter = objects.Count();
            var filteredList = objects.Where(DoesNameLengthGreaterNumber);
            while (filteredList.Count() != counter)
            {
                counter = filteredList.Count();
                filteredList = filteredList.FilterByNameLengthAndPosition(); 
            }
            return filteredList;
        }

        public static bool DoesNameLengthGreaterNumber(IName obj, int number)
            => obj?.Name?.Length > number;
        #endregion

        #region Task 3
        public static IEnumerable<GroupWordInfo> GetStringInformation(this string @string)
        {
            return new Regex(@"\w+").Matches(@string ?? "")
                                    .GroupBy(e => e.Value.Length)
                                    .OrderByDescending(e => e.Key)
                                    .Select((e, q) => new GroupWordInfo()
                                    {
                                        WordLength = e.Key,
                                        GroupNumber = ++q,
                                        Words = e.Select(q => q.Value)
                                    })
                                    .OrderByDescending(e => e.WordNumber);
        }

        public static void WriteInConsoleStringInformation(this string @string)
        {
            if (string.IsNullOrEmpty(@string))
                return;
            foreach (var word in @string.GetStringInformation())
            {
                Console.WriteLine(word);
            }
        }

        #endregion

        #region Task 4
        public static Dictionary<int, string> CreateRussianBook(this string @string)
        {
            return new Regex(@"\w+").Matches(@string ?? "")
                                    .Select((e, q) => new { Word = e.Value.Translate(), Index = q / 3 })
                                    .GroupBy(e => e.Index)
                                    .ToDictionary(e => e.Key, 
                                                  e => string.Join(" ", e.Select(q => q.Word?.ToUpper())));
        }
        #endregion
    }
}
