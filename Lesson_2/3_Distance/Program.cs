namespace Distance
{
    //Дана відстань у сантиметрах.Знайти кількість повних метрів у ньому.
    //566 см => 5 м
    class Program
    {
        static void Main(string[] args)
        {
            int dist;
            int initDist;
            Console.WriteLine("Enter distance:");
            string input = Console.ReadLine();
            dist = int.Parse(input); // or INT32.Parse(input)
            initDist = dist;
            dist /= 100; // == dist = dist /100;  // int input 

            Console.WriteLine($"Distanse is equal {dist}, initial distance is {initDist}");
            Console.WriteLine("Distanse is equal {0}, initial distance is {1}", dist, initDist);
        }
    }
}