namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI; 

            // const double EXP; ERROR

            // PI = 3.14; // ERROR

            var variable = (5 + 2) / 2;

            int a = 5;
            char c = 'a';
            string s = "test";
            // null 

            string t = null;

            //var var2 = null; ERROR


            int num1 = 300;
            byte num2 = (byte)num1;

            Console.ReadKey();
        }

        // XML comments
        /// <summary>
        /// Test description
        /// </summary>
        /// <param name="a">Test param</param>
        /// <returns>Test return value</returns>
        static int Print(int a)
        {
            Console.WriteLine("Test");
            return a;
        }
    }
}