using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_1._2
{
    public struct Base : IBase
    {
        public string GetInfo()
        {
            return "Base class";
        }
    }
}
