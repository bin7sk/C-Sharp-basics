using System;

namespace OOP 
{
    
    internal class Program
    {
        static Program() 
        {
            Console.WriteLine("static constructor of class with main fuction.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main() starts here:");
            ConstVSReadOnly cvro = new ConstVSReadOnly(2022);
            Console.WriteLine("const from class: " + ConstVSReadOnly.pi);
            Console.WriteLine($"readonly = {cvro.number}");

            // Overloading ToString()
            Employee e = new Employee();
            e.FirstName = "Bob";
            e.LastName = "Diew";
            Console.WriteLine(e.ToString());


        }
    }
    static class MyEasyClass
    {
        static private string static_info;

        static MyEasyClass()
        {
            static_info = "static constructor to check understanding";
            Console.WriteLine("Static constructor.");
        }
    }

    class ConstVSReadOnly
    {
        public const double pi = 3.14;

        public readonly uint number;

        public ConstVSReadOnly(uint _number)
        { 
            number = _number;
        }

    }

    class Employee
    { 
        public string FirstName;
        public string LastName;

        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}