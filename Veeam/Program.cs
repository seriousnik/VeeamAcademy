using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Veeam.Tasks._1._1._1._1;
using Veeam.Tasks._1._1_1._2;
using Veeam.Tasks._1._1_2_delegate;
using Veeam.Tasks._1._1_3_LINQ;

namespace Veeam
{
    class Program 
    {
        class Testname : IName
        {
            public string Name { get; set; }

            public Testname(string name)
            {
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            var textInEnglish = "This dog eats too much vegetables after lunch";
            var answer = textInEnglish.CreateRussianBook();


            //string phrase = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";
            //var regex = new Regex(@"\w+");
            //var test = regex.Matches(phrase).Select(e => e.Value).ToList();
            //string[] words = phrase.Split();
            ////phrase = null;

            //phrase.WriteInConsoleStringInformation();

            Console.ReadLine();
        }
    }
}
