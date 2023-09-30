namespace Figure
{
    internal class Point
    {
        int x;
        int y;
        string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        //DateTime Date { get; }

        public Point(int x, int y, string name = "None") //, DateTime date)
        {
            X = x;
            Y = y;
            this.name = name;

            //date = DateTime.Now;
        }
    }
}
