using System.Collections.Generic;
using System.Text;

namespace Pather.Logic
{
    public class Map
    {
        public Map(char[,] charMap)
        {
            Raw = charMap;
            SizeX = charMap.GetLength(0);
            SizeY = charMap.GetLength(1);
            FindPoints(charMap);
        }

        public int SizeX { get; private set; }

        public int SizeY { get; private set; }

        public Point[] Points { get; private set; }

        public char[,] Raw { get; private set; }

        private void FindPoints(char[,] charMap)
        {
            var points = new List<Point>();

            for (int i = 0; i < charMap.GetLength(0); i++)
            {
                for (int j = 0; j < charMap.GetLength(1); j++)
                {
                    if (charMap[i, j] == Constants.PointSymbol)
                    {
                        points.Add(new Point(i, j));
                    }
                }
            }

            Points = points.ToArray();
        }

        public override string ToString()
        {
            var maptToText = new StringBuilder();

            for (int i = 0; i < Raw.GetLength(1); i++)
            {
                var line = (char[])Raw.GetValue(i);
                maptToText.Append(line);
            }

            return base.ToString();
        }
    }
}
