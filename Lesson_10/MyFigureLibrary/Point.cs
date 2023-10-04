namespace MyFigureLibrary
{
    public class Point
    {
        int x;
        int y;
        string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point(int x, int y, string name = "None") 
        {
            X = x;
            Y = y;
            this.name = name;
        }
    }
}