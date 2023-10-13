namespace Plugin
{
    internal class CalculatorPlugin : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("CalculatorPlugin");
        }

        public void Print() => Console.WriteLine("Print CalculatorPlugin"); 
    }
}
