using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    internal class Qes4
    {   
        //4-Create a base class named Employee with method Work that prints "Employee is working".
        //Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
        //Ensure that the Manager class also calls the Work method of the Employee class within its overridden method.


        public virtual void work()
        {
            Console.WriteLine("Employee is working");
        }
       
    }
    internal class manger : Qes4 
    { 

        public override void work()
        {
            base.work();
            Console.WriteLine("Manger is managing");
        }
    }
}
