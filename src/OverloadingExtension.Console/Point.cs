using System.Net.NetworkInformation;

namespace OverloagingExtension.Console
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X+ b.X, a.Y+ b.Y);
        }

        public static implicit operator int(Point a)
        {
            return a.X;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}