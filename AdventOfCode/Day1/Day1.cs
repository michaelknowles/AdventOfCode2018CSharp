using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Day1
    {
        private IEnumerable<int> Changes { get; }

        public Day1(IEnumerable<string> changeStrings)
        {
            List<int> changes = new List<int>();
            foreach (var t in changeStrings)
            {
                Int32.TryParse(t, out var change);
                changes.Add(change);
            }
            Changes = changes;
        }

        public void Output()
        {
            Console.WriteLine("Day 1");
            Console.WriteLine("Part 1:");
            Console.WriteLine(GetFrequency());
            Console.WriteLine("Part 2:");
            Console.WriteLine(GetSameFrequency());
        }

        public int GetFrequency()
        {
            /*
             * Add all changes to get the final frequency
             */
            int frequency = 0;
            foreach(int change in Changes) {
                frequency += change;
            }

            return frequency;
        }

        public int GetSameFrequency()
        {
            /*
             * Find which frequency occurs twice first
             * List may be looped multiple times
             */
            int frequency = 0;
            List<int> frequencies = new List<int>();

            bool LoopFrequencies()
            {
                foreach(int change in Changes)
                {
                    frequency += change;
                    if(frequencies.Contains(frequency)) return true;
                    frequencies.Add(frequency);
                }

                return false;
            }

            bool same = false;
            while(!same)
            {
                same = LoopFrequencies();
            }

            return frequency;
        }

    }
}
