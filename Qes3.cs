using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    internal class Qes3
    {
        public int real { get; set; }
        public int imag { get; set; }




        public static Qes3 operator + (Qes3 left, Qes3 right)
            {
                return new Qes3()
                {
                real = (left?.real ?? 0) + (right?.real ?? 0),
                imag = (left?.imag ?? 0) + (right?.imag ?? 0)
            };
        }
    }


} 

