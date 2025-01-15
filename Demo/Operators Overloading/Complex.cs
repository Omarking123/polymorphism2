using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism.Operators_Overloading
{
    internal class Complex
    {

        public int real { get; set; }
        public int imag { get; set; }
        #region Operators Overloading


        // overloading operator must be non-private class member function

        //public static Complex operator + (Complex left, Complex right)
        //{
        //    return new Complex()
        //    {
        //        real = (left?.real??0) + (right?.real??0),
        //        imag = (left?.imag??0) + (right?.imag??0)
        //    };
        //}

        //public static Complex operator -(Complex left, Complex right)
        //{
        //    return new Complex()
        //    {
        //        real = (left?.real ?? 0) - (right?.real ?? 0),
        //        imag = (left?.imag ?? 0) - (right?.imag ?? 0)
        //    };
        //}


        #endregion
        #region unary operators
        //public static Complex operator ++(Complex C)
        //{


        //    return new Complex()
        //    {
        //        real = (C?.real ?? 0) + 1,
        //        imag = (C?.imag ?? 0)
        //    };



        //}
        //public static Complex operator --(Complex C)
        //{


        //    return new Complex()
        //    {
        //        real = (C?.real ?? 0) - 1,
        //        imag = (C?.imag ?? 0)
        //    };



        //} 
        #endregion

        #region relational 
        //public static bool operator >(Complex left, Complex right)
        //{
        //    if (left?.real == right?.real)
        //        return left?.imag > right?.imag;
        //    else
        //        return left?.real > right?.real;
        //}
        //public static bool operator <(Complex left, Complex right)
        //{
        //    if (left?.real == right?.real)
        //        return left?.imag < right?.imag;
        //    else
        //        return left?.real < right?.real;
        //}


        #endregion

        #region casting operators 


        #region example 01 ;
        //public static /*int*/ explicit operator int(Complex c)
        //{
        //    return c?.real ?? 0;

        //} 
        #endregion

        #region exmpale 2 
        //public static /*string*/ explicit operator string(Complex c)
        //{
        //    return c.real.ToString();
        //}

        #endregion
        #endregion

        public override string ToString()
        {
            return $"{real} + {imag}i";
        }
    }
}
    
