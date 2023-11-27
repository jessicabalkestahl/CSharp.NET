
namespace ConsoleAppActivity41
{
    internal class Coordinates
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public static int TotalCoordinates { get; private set; }

        public Coordinates()
        {
            X = 0;
            Y = 0;
            IncrementCoordinatesNumber();
        }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
            IncrementCoordinatesNumber();
        }

        private static void IncrementCoordinatesNumber()
        {
            TotalCoordinates++;
        }

        public void DecrementCoordinates(int deltaX, int deltaY)
        {
            X -= deltaX;
            Y -= deltaY;
        }  
        
        public void IncrementCoordinates(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public bool AreCoordinatesPositive()
        {
            return X > 0 && Y > 0;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
        
    }
}