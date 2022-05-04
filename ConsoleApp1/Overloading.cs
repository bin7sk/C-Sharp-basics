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
            TypesConversion.Conversion();

            // value vs reference

            cACC refer = new cACC() 
            { 
                name = "class",
                number = 11
            };
            sACC value = new sACC()
            { 
                name = "struct",
                number = 77
            };
            
            cACC refer2 = refer;
            refer2.name = "refer2";
            Console.WriteLine(refer.name);

            sACC value2 = value;
            value2.name = "value2";
            Console.WriteLine(value.name);
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
