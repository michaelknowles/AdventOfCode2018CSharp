using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1
            var changeStrings = ReadInput("Day1/Day1-Input.txt");
            Day1 day1 = new Day1(changeStrings);
            day1.Output();
            
            // Day 2
            var boxIDStrings = ReadInput("Day2/Day2-Input.txt");
            Day2 day2 = new Day2(boxIDStrings);
            day2.Output();
        }

        static IEnumerable<string> ReadInput(string fileName)
        {
            return System.IO.File.ReadAllLines(fileName);
        }
    }
}
