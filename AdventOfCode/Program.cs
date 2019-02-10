using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1
            Console.WriteLine("Day 1");
            var changeStrings = readInput("Day1/Day1-Input.txt");
            List<int> changes = new List<int>();
            foreach (var t in changeStrings)
            {
                Int32.TryParse(t, out var change);
                changes.Add(change);
            }
            Day1 day1 = new Day1(changes);
            Console.WriteLine("Part 1:");
            Console.WriteLine(day1.GetFrequency());
            Console.WriteLine("Part 2:");
            Console.WriteLine(day1.GetSameFrequency());
            
            // Day 2
            Console.WriteLine("Day 2");
            var boxIDStrings = readInput("Day2/Day2-Input.txt");
            Day2 day2 = new Day2(boxIDStrings);
            day2.Checksum();
            Console.WriteLine("Part 1:");
            Console.WriteLine(day2.Checksum());
            Console.WriteLine("Part 2:");
            var letters = day2.CommonLetters();
            foreach (var letter in letters)
            {
                Console.Write(letter);
            }
        }

        static IEnumerable<string> readInput(string fileName)
        {
            return System.IO.File.ReadAllLines(fileName);
        }
    }
}
