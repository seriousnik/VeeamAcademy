using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_2_delegate
{
    public interface IPublisher
    {
        void Subscribe(Action action);
    }   
}
