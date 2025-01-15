using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism.Ploymorphism_overriding
{
    class typeA
    {
        public int A { get; set; }
        public typeA(int A)
        {
            this.A = A;
        }


        public void Myfunc01()
        {
            Console.WriteLine("Iam Base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"Type : a = {A}");
        }

    }

    class TypeB : typeA
    {
        public int B { get; set; }
        public TypeB(int A, int B) : base(A)
        {
            this.B=B;
        }


        public new void  Myfunc01()
        {
            Console.WriteLine($"My func01 =>I am Derived [child] ");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"my fun02 =>TypeB : A {A}, B= {B}");
        }


    }
}
