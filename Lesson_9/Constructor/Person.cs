namespace Constructor
{
    internal class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name; // null

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person() // конструктор за замовчуванням
        {
            age = 18;
            name = "Smith";
            Console.WriteLine("Hello from default constructor!");
            Console.WriteLine("age = {0}", age);
            Console.WriteLine("name = {0}", name);
        }

        private int Test()
        {
            return 0;
        }

        //public Person(int age, string name)
        //{
        //    this.age = age;
        //    this.name = name;
        //    Console.WriteLine("Hello from user constructor with 2 parameters!");
        //    Console.WriteLine("age = {0}", age);
        //    Console.WriteLine("name = {0}", name);
        //}

        //public Person(string name) : this(50, name)
        //{
        //    this.name = name;
        //    // this.age = 50;
        //    Console.WriteLine("Hello from user constructor with 1 parameters!");
        //    Console.WriteLine("age = {0}", age);
        //    Console.WriteLine("name = {0}", name);
        //}

        public Person(int age = 18, string name = "None")
        {
            this.age = age;
            this.name = name;
            Console.WriteLine("Hello from user constructor with default defined parameters!");
            Console.WriteLine("age = {0}", age);
            Console.WriteLine("name = {0}", name);
        }
    }
}
