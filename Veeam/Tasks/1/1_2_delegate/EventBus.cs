using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veeam.Tasks._1._1_2_delegate
{
    public class EventBus
    {
        private event Action OnSmthWasHappened;
        public EventBus(IPublisher publisher)
        {
            if (publisher == null)
                throw new ArgumentNullException(nameof(publisher));
            publisher.Subscribe(() => OnSmthWasHappened?.Invoke());
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (subscriber == null)
                return;
            OnSmthWasHappened += subscriber.OnEvent;
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (subscriber == null)
                return;
            OnSmthWasHappened -= subscriber.OnEvent;
        }
    }
}
