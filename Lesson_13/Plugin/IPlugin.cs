namespace Plugin
{
    internal interface IPlugin
    {
        void Execute();

        void Print() => Console.WriteLine("Print IPlugin");
    }
}
