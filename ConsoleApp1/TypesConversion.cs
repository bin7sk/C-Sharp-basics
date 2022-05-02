using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class TypesConversion
    {
        public static void Conversion()
        {
            
            int x = 0x1ffff;
            char ch = (char)x; // explicit
            Console.WriteLine("int = " + x);
            Console.WriteLine("char = " + (int)ch);
            double d = x; //implicit
            float f = (float)d;

            double dnum = 12.345;
            int inum = (int)dnum;
            Console.WriteLine("inum = " + inum);
            inum = Convert.ToInt32(inum);
            Console.WriteLine("inum = " + inum);
            string s = "456,789";
            dnum = Convert.ToDouble(s);
            Console.WriteLine(dnum);

        }
    }
}
