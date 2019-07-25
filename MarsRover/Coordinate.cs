namespace MarsRover
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool CheckBounds(Coordinate maxCoordinate)
        {
            if (X >= 0 && Y >= 0 && X <= maxCoordinate.X && Y <= maxCoordinate.Y)
                return true;
            return false;
        }
    }
}
