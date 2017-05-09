namespace Pather.Logic
{
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X coordinate.
        /// </summary>
        /// <remarks>Zero-based.</remarks>
        public int X { get; private set; }

        /// <summary>
        /// Y coordinate.
        /// </summary>
        /// <remarks>Zero-based.</remarks>
        public int Y { get; private set; }
    }
}
