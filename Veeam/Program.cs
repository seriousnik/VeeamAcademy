using System;
using System.Collections.Generic;
using Veeam.Tasks._1._1._1._1;
using Veeam.Tasks._1._1_1._2;

namespace Veeam
{
    class Program
    {
        /*
         Создайте свой иммутабельный (immutable) тип. При изменении какого-либо из полей
            создается новый объект. В качестве примера можете взять тип String.
         */

        /*Попробуйте симитировать наследование и переопределение виртуального метода в
структурах.
          class Base
 {
 public virtual string GetInfo()
 {
 return "Base class";
 }
 }
 class A : Base
 {
 public override string GetInfo()
 {
 return "A class";
 }
 }
…
 Base b = new A()
         */
        static void Main(string[] args)
        {
            Base b = new A();
            Console.WriteLine(b.GetInfo());
            Console.WriteLine(new A().GetInfo());
        }
    }
}
