using Pather.Logic;
using System;
using System.IO;

namespace Pather
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect input parameters. Use: pather.exe input.txt output.txt");
                return;
            }

            var inputFilePath = args[0];
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Incorrect input parameters. Input file was not found");
                return;
            }

            var inputContent = File.ReadAllText(inputFilePath);

            var outputContent = FindPath(inputContent);

            if (!string.IsNullOrWhiteSpace(outputContent))
            {
                File.WriteAllText(args[1], outputContent);
                Console.WriteLine("Success");
            }
        }

        private static string FindPath(string text)
        {
            try
            {
                var mapLoader = new MapLoader();
                var map = mapLoader.Parse(text);

                Console.WriteLine("Input:");
                Console.WriteLine(map.ToString());
                Console.WriteLine();

                var pathFinder = new PathFinder();
                pathFinder.FindPathes(map);
                var result = map.ToString();

                Console.WriteLine("Output:");
                Console.WriteLine(result);
                Console.WriteLine();

                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine();
                Console.WriteLine("Unable to build path. An exception occured:");
                Console.WriteLine(exception.GetBaseException().Message);
                return null;
            }
        }
    }
}
