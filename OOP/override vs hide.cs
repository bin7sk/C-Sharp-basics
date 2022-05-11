namespace OOP
{ 
    class BaseClass
    { 
        public virtual void virt_method()
        {
            Console.WriteLine("virtual base class");
        }
        public void hidable()
        { 
            Console.WriteLine("Writable method");
        }
    }

    class SubClass : BaseClass
    { 
        public override void virt_method()
        { 
            Console.WriteLine("overrided method");
        }
        public new void hidable()
        { 
            Console.WriteLine("hided method");
        }

    }

}