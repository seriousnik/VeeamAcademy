using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_2_delegate
{
    public class Subscriber1 : ISubscriber
    {
        public void OnEvent()
        {
            Console.WriteLine(GetType().Name + " got notification");
        }
    }
}
