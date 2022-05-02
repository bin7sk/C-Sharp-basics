using System;

namespace project
{

    class Overloading
    {
        static void Main(string[] args)
        {
            RationalNumber r = new RationalNumber(3, 4);
            r.PrintNumber();
            double d = (double)r;
            Console.WriteLine("d = " + d);
            r = 25;
            r.PrintNumber();


        }
    }

    class RationalNumber
    {
        int numerator;
        int denominator;

        public RationalNumber(int nu, int de)
        {
            numerator = nu;
            denominator = de;
        }
        public void PrintNumber()
        {
            Console.WriteLine(numerator + "/" + denominator);
        }

        public static implicit operator RationalNumber(int whole)
        {
            return new RationalNumber(whole, 1);
        }

        public static explicit operator double(RationalNumber r)
        {
            return (double)r.numerator / r.denominator;
        }



    }
}