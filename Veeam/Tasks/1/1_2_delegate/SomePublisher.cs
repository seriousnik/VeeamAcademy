using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_2_delegate
{
    public class SomePublisher : IPublisher
    {
        private Action _notify;
        public void Subscribe(Action action)
        {
            _notify = action;
        }

        public void Post()
        {
            //do smth
            _notify?.Invoke();
        }
    }
}
