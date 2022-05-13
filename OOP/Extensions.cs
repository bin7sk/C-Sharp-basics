namespace OOP
{ 
    static class Extensions
    { 
        public static void extended(this SubClass obj)
        { 
            Console.WriteLine("Extended");
            Console.WriteLine(obj.what);
        }
    }
}