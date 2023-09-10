namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Знайти кількість цифр у числі

            Random random = new Random();
            int number = random.Next();
            Console.WriteLine("Random - {0}", number);

            byte countDigits = CountDigits(number);
            Console.WriteLine("countDigits - {0}", countDigits);
            Console.ReadKey();
        }

        private static byte CountDigits(int number)
        {
            byte count = 1;

            while(number > 9)
            {
                number /= 10; // 145/10 = 14
                               // 14/10 = 1
                count++;
            }

            return count;
        }
    }
}