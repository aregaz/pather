using Pather.Logic;
using System;

namespace Pather
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var filePath = args[0];
            ////var fileContent = File.ReadAllText(filePath);

            var testText1 =
                "....................." + Environment.NewLine +
                "...#................." + Environment.NewLine +
                "..................#.." + Environment.NewLine +
                "....................." + Environment.NewLine +
                "....................." + Environment.NewLine +
                ".........#..........." + Environment.NewLine +
                ".....................";

            var map = new MapLoader().Parse(testText1);
            Console.WriteLine("Input:");
            Console.WriteLine(map.ToString());
            Console.WriteLine();

            var resultMap = new PathFinder().FindPathes(map);
            Console.WriteLine("Output:");
            Console.WriteLine(resultMap.ToString());
            Console.WriteLine();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
