using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_1._2
{
    public struct A : IBase
    {
        public static implicit operator Base(A a)
        {
            return new Base();
        }

        public string GetInfo()
        {
            return "A class";
        }
    }
}
