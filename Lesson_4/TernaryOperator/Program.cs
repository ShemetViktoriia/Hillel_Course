//Написати програму, яка перевіряє введене число на парність/непарність.
namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //byte genRandom = (byte)random.Next(2);
            //string output = (genRandom == 0) ? "Bad" : "Good"; // ternary operator

            //int a = 0;
            //bool x = (a == 0) ? true : false; // Don't do this


            // 1. Знайти максимум та мінімум двох чисел.
            int a = 15;
            int b = 56;

            int min, max;

            min = (a<b) ? a : b;
            max = (a>b) ? a : b;
            Console.WriteLine($"min - {min}");
            Console.WriteLine($"max - {max}");

        }
    }
}