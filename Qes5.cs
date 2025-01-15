using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    internal class Qes5
    {
           public  virtual void Baseclass()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }

    internal class DerivedClass1 : Qes5
    {
        public override void Baseclass()
        {
            
            Console.WriteLine("massage from DerivedClass1");
        }
    }
    internal class DerivedClass2 : Qes5 {
        public new void Baseclass() 
        {
            Console.WriteLine("massage from DerivedClass2");
        }
    }

}
// 5- Create a base class BaseClass with a virtual method DisplayMessage that prints "Message from BaseClass".
//Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
//Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
//And explain the difference between using override and new (using binding behavior)	
