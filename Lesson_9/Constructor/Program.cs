namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // конструктор 
            // конструктор по замовчуванню, без параметрів
            //Person person = new Person();

            // конструктор з параметрами // користувальницькі
            //Person person1 = new Person(36, "Volodymyr");

            // блок ініціалізатора та конструктор
            //Person person2 = new Person(36, "Volodymyr") { Age = 25, Name = "Anna" };
            //Console.WriteLine(person2.Age);
            //Console.WriteLine(person2.Name);

            // ланцюг конструкторів, this  vs конструктор із параметрами по замовчуванню
            //Person person3 = new Person("Oleg");

            Person person4 = new Person(name: "Tom");

            // this 

            // StringBuilder

        }
    }
}