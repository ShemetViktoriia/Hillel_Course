namespace VirtualMethodsAndAbstractClasses
{
    abstract class Figure
    {
        public Figure(string name)
        {
            Name = name;
            Console.WriteLine("Ctor from Abstract class");
        }
        public abstract string Name { get; set; } // абстрактні члени містяться тільки в абстрактному класі
        // модифікатор абстрактного члену не може бути private

        public abstract void Print(); // оголошення абстрактного методу, реалізації НЕМАЄ!!!
    }

    class Rectangle : Figure
    {
        public Rectangle(string name) : base(name)
        {
                
        }
        public override string Name { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Figure = {Name}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
          // Figure classFigure = new Figure(); compile error 


         Figure rectangle = new Rectangle("Rectangle");
         rectangle.Print();





        }
    }
}

