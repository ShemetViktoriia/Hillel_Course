namespace TwoDigitsNumber
{
    // Дано двозначне число.
    // Знайти: а) число десятків у ньому; б) число одиниць у ньому; в) суму його цифр; г) добуток його цифр.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int inputNum = int.Parse(Console.ReadLine());

            int firstDigit = inputNum / 10;
            //int secondDigit = inputNum - 10 * firstDigit; // 1 
            int secondDigit = inputNum % 10; // 2 
            Console.WriteLine($"{firstDigit}");
            Console.WriteLine($"{secondDigit}");
            Console.WriteLine($"{firstDigit + secondDigit}");
            Console.WriteLine($"{firstDigit * secondDigit}");
            Console.ReadKey();
        }
    }
}
