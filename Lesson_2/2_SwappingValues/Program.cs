namespace SwappingValues
{
    // Поміняти місцями значення двох змінних? Чи можна це зробити без ще однієї тимчасової змінної.
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 7;

            //1
            byte buf;
            buf = a;
            a = b;
            b = buf;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //2      
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
            a = (byte)(a + b);
            b = (byte)(a - b);
            a = (byte)(a - b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}