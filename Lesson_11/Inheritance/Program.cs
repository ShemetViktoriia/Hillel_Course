
// BaseClass
class BaseClass
{
    protected int xBaseClass;

    public BaseClass()
    {
        Console.WriteLine("From BaseClass ctor");
    }

    public BaseClass(int xBaseClass)
    {
        this.xBaseClass = xBaseClass;
        Console.WriteLine($"From BaseClass ctor with param {xBaseClass}");
    }

    protected void PrintBaseClass()
    {
        Console.WriteLine("Hello from BaseClass");
    }
}

// DerivedClss
class DerivedClass : BaseClass
{
    protected int xDerivedClass;

    public DerivedClass(int xDerivedClass, int xBaseClass) : base(xBaseClass)
    {
        this.xDerivedClass = xDerivedClass;
        Console.WriteLine($"From DerivedClass ctor with param {xDerivedClass}");
    }

    protected void PrintDerivedClass()
    {
        int a = xBaseClass;
        PrintBaseClass();
        Console.WriteLine("Hello from DerivedClass");
    }
}

// DerivedDerivedClass
class DerivedDerivedClass : DerivedClass // : BaseClass
{
    public DerivedDerivedClass(int xDerivedClass, int xBaseClass) : base(xDerivedClass, xBaseClass)
    {
            
    }

    public void PrintDerivedDerivedClass()
    {
        PrintDerivedClass();
        PrintBaseClass();
        Console.WriteLine("Hello from DerivedDerivedClass");
    }
}

sealed class SealedClass
{

}

//class B : SealedClass
//{

//}



namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //var derivedDerivedClass = new DerivedDerivedClass();
            //derivedDerivedClass.PrintDerivedDerivedClass();

            BaseClass baseClass = new BaseClass(10);
            DerivedClass derivedClass = new DerivedClass(20, 30);


            byte a = 250;
            int c = 1000;
            int b = a; // неявне приведення типу

            byte d = (byte)c; // явне приведення типу
            Console.WriteLine(d);

            //baseClass = derivedClass;  // DerivedClass : BaseClass - // неявне приведення типу

            derivedClass = (DerivedClass)baseClass; // // явне приведення типу

        }
    }
}

