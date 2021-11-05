using System;
using System.Collections.Generic;
using Veeam.Tasks._1._1._1._1;
using Veeam.Tasks._1._1_1._2;
using Veeam.Tasks._1._1_2_delegate;

namespace Veeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new SomePublisher();           
            var eventBus = new EventBus(publisher);
            var subscriber1 = new Subscriber1();
            var subscriber2 = new Subscriber2();
            eventBus.Subscribe(subscriber1);
            Console.WriteLine("First post");
            publisher.Post();

            eventBus.Subscribe(subscriber2);
            Console.WriteLine("Second post");
            publisher.Post();

            eventBus.Unsubscribe(subscriber1);
            Console.WriteLine("Thrird post");
            publisher.Post();

            Console.ReadLine();
        }
    }
}
