using System;
using System.Linq;

namespace Pather.Logic
{
    public class MapLoader
    {
        public Map Parse(string text)
        {
            if (!MapHasTwoPoints(text))
            {
                throw new Exception("Invalid input. Map must contain at least two points.");
            }

            var lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            if (!HasEqualLength(lines))
            {
                throw new Exception("Invalid input. Lines has different length.");
            }

            var fileContentWithoutBrakes = string.Join(string.Empty, lines);
            if (!ContainsOnlyDotsAndPoints(fileContentWithoutBrakes))
            {
                throw new Exception("Invalid input. Map must contain . and # symbols only.");
            }

            var m = lines[0].Length; // all lines has same length - already checked
            var n = lines.Length;
            var charArray = new char[m, n];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    charArray.SetValue(lines[j][i], i, j);
                }
            }

            return new Map(charArray);
        }

        private bool HasEqualLength(string[] lines)
        {
            return lines.Select(l => l.Length).GroupBy(l => l).Count() == 1;
        }

        private bool MapHasTwoPoints(string text)
        {
            return text.Count(c => c == Constants.PointSymbol) >= 2;
        }

        private bool ContainsOnlyDotsAndPoints(string text)
        {
            var usedSymbols = text.GroupBy(c => c).Select(g => g.First());

            return usedSymbols.Count() == 2
                && usedSymbols.Contains(Constants.EmptySymbol)
                && usedSymbols.Contains(Constants.PointSymbol);
        }
    }
}
