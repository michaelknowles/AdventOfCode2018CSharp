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
            string[] changeStrings = System.IO.File.ReadAllLines("Day1-Input.txt");
            List<int> changes = new List<int>();
            for(int i = 0; i < changeStrings.Length; i++)
            {
                int change;
                Int32.TryParse(changeStrings[i], out change);
                changes.Add(change);
            }
            Day1 day1 = new Day1(changes);
            Console.WriteLine("Part 1:");
            Console.WriteLine(day1.GetFrequency());
            Console.WriteLine("Part 2:");
            Console.WriteLine(day1.GetSameFrequency());
        }
    }
}
