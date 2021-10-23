using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    class Rational
    {
        int numerator;
        int delimeter;

        public Rational()
        {
            numerator = 0;
            delimeter = 1;
        }
        public Rational(int numerator, int delimeter)
        {
            this.numerator = numerator;
            this.delimeter = delimeter;
        }
        static public Rational operator +(Rational r1, Rational r2) 
        {
            int resultNum = r1.numerator * r2.delimeter + r2.numerator * r1.delimeter;
            int resultDel = r1.delimeter * r2.delimeter;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }
        static public Rational operator -(Rational r1, Rational r2)
        {
            int resultNum = r1.numerator * r2.delimeter - r2.numerator * r1.delimeter;
            int resultDel = r1.delimeter * r2.delimeter;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }
        static public Rational operator *(Rational r1, Rational r2)
        {
            int resultNum = r1.numerator * r2.numerator;
            int resultDel = r1.delimeter * r2.delimeter;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }
        static public Rational operator /(Rational r1, Rational r2)
        {
            int resultNum = r1.numerator *r2.delimeter ;
            int resultDel = r1.delimeter *r2.numerator ;
            Rational r = new Rational(resultNum, resultDel);
            return r;
        }
        //public Rational Sum(Rational other)
        //{
        //    int resultNum = numerator * other.delimeter + other.numerator * delimeter;
        //    int resultDel = delimeter * other.delimeter;
        //    Rational r = new Rational(resultNum, resultDel);
        //    return r;
        //}
        //public Rational Subtrac(Rational other)
        //{
        //    int resultNum = numerator * other.delimeter - other.numerator * delimeter;
        //    int resultDel = delimeter * other.delimeter;
        //    Rational r = new Rational(resultNum, resultDel);
        //    return r;
        //}
        //public Rational Multiply(Rational other)
        //{
        //    int resultNum = numerator * other.numerator;
        //    int resultDel = delimeter * other.delimeter;
        //    Rational r = new Rational(resultNum, resultDel);
        //    return r;
        //}

        //public Rational Divide(Rational other)
        //{
        //    int resultNum = numerator * other.delimeter;
        //    int resultDel = delimeter * other.numerator;
        //    Rational r = new Rational(resultNum, resultDel);
        //    return r;
        //}
        override public string ToString()
        {
            return numerator + "/" + delimeter;
        } 
        public void Reduction()
        {
            int m = Math.Abs(numerator);
            int n = Math.Abs(delimeter);
            while (m !=n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }
            int nod = n;
            numerator = numerator / nod;
            delimeter = delimeter / nod;
        }
    }
}
