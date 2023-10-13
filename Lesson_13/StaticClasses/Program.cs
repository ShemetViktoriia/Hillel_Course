namespace StaticClasses
{
    class Person
    { 
        public int Age { get; set; }
        public static int AgeOfPassport { get; set; }

        //public Person()
        //{
        //    Age = 10;
        //    Console.WriteLine("Instance Ctor");
        //}

        static Person()
        {
            AgeOfPassport = 14;
            Console.WriteLine("Static Ctor");
            // this.Age = 10;
            //Age = 10;
        }

        public Person(int age)
        {
            AgeOfPassport = 16;
            Age = age;
            Console.WriteLine("Parameter Ctor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(50);
            Person bob = new Person(60);
            Console.WriteLine(Person.AgeOfPassport);
            Console.ReadKey();
        }
    }
}

