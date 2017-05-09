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
                "....................." +
                "...#................." +
                "....................." +
                "....................." +
                "....................." +
                "...#................." +
                ".....................";

            var map = new MapLoader().Parse(testText1);
            var resultMap = new PathFinder().FindPathes(map);

            Console.WriteLine("Result map:");
            Console.WriteLine();
            Console.WriteLine(resultMap.ToString());
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
