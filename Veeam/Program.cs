using System;
using System.Collections.Generic;
using Veeam.Tasks._1._1._1._1;
using Veeam.Tasks._1._1_1._2;

namespace Veeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new A();
            Console.WriteLine(b.GetInfo());
            Console.WriteLine(new A().GetInfo());
        }
    }
}
