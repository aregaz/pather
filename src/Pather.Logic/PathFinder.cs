using System;
using System.Linq;

namespace Pather.Logic
{
    public class PathFinder
    {
        public Map FindPathes(Map map)
        {
            var points = map.Points
                .Select(point => new { Point = point, Index = point.Y * map.SizeX + point.X })
                .OrderBy(point => point.Index)
                .Select(point => point.Point)
                .ToList();
            for (int i = 0; i < points.Count - 1; i++)
            {
                DrawPathBetweenPoints(points[i], points[i + 1], map.Raw);
            }

            return map;
        }

        private void DrawPathBetweenPoints(Point point1, Point point2, char[,] map)
        {
            if (point1.X == point2.X)
            {
                for (int i = 0; i < point2.Y - point1.Y; i++)
                {
                    map[point1.X, point1.Y + i] = Constants.PathSymbol;
                }
            }

            if (point1.Y == point2.Y)
            {
                for (int i = 0; i < point2.X - point1.X; i++)
                {
                    map[point1.X + i, point1.Y] = Constants.PathSymbol;
                }
            }

            throw new NotImplementedException();
        }

    }
}
