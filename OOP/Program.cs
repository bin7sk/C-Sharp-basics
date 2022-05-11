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

            // overriding ToString()
            Employee e = new Employee();
            e.FirstName = "Bob";
            e.LastName = "Diew";
            Console.WriteLine(e.ToString());

            // overriding Equals()
            Employee e1 = new Employee();
            e1.FirstName = "e1_fName";
            e1.LastName = "e1_lName";
            Employee e2 = new Employee();
            e2.FirstName = "e1_fName";
            e2.LastName = "e1_lName";
            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1.Equals(e2));

            //playing with properties

            Employee Bob = new Employee("Bob", "Duclas");
            Bob.salary = 2000; // dollars
            Console.WriteLine(Bob.salary);

            //copy constructor
            Employee N = new Employee(Bob);
            Console.WriteLine(N.ToString());

            //internal 
            Library.Player gamer = new Library.Player("Gamer", 1);
            gamer.info();
            
            SubClass sub = new SubClass();
            sub.virt_method();
            sub.hidable();


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

        int _salary;
        public int salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }

        public Employee() { }
        public Employee(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
        //copy constructor
        public Employee(Employee src)
        {
            FirstName = src.FirstName;
            LastName = src.LastName;
        }

        ~Employee()
        {
            Console.WriteLine("Destructor");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Employee))
                return false;

            return (FirstName == ((Employee)obj).FirstName)
                     &&
                    ((LastName == ((Employee)obj).LastName));


        }


    }
    partial class devided
    { 
        int y;
        public void print_newline()
        { 
            Console.WriteLine();
        }
    }
}