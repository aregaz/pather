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
            int targetX;
            int targetY;

            if (point1.X == point2.X)
            {
                for (int i = 1; i < point2.Y - point1.Y; i++)
                {
                    targetX = point1.X;
                    targetY = point1.Y + i;

                    SetPathPoint(targetX, targetY, map);
                }
            }
            else if (point1.Y == point2.Y)
            {
                for (int i = 1; i < point2.X - point1.X; i++)
                {
                    targetX = point1.X + i;
                    targetY = point1.Y;

                    SetPathPoint(targetX, targetY, map);
                }
            }
            else
            {
                var middlePoint = new Point(point1.X, point2.Y);

                DrawPathBetweenPoints(point1, middlePoint, map);
                DrawPathBetweenPoints(middlePoint, point2, map);

                SetPathPoint(middlePoint.X, middlePoint.Y, map);
            }
        }

        private void SetPathPoint(int targetX, int targetY, char[,] map)
        {
            if (map[targetX, targetY] != Constants.EmptySymbol)
            {
                throw new Exception("Complex case. Not going to implement for test task.");
            }

            map[targetX, targetY] = Constants.PathSymbol;
        }
    }
}
