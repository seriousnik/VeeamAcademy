Попробуйте симитировать наследование и переопределение виртуального метода в
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