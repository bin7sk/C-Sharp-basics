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

}