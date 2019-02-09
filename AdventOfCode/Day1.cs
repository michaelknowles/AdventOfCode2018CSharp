using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Day1
    {
        private List<int> Changes { get; }

        public Day1(List<int> changes) => Changes = changes;

        public int GetFrequency()
        {
            int frequency = 0;
            foreach(int change in Changes) {
                frequency += change;
            }

            return frequency;
        }

        public int GetSameFrequency()
        {
            int frequency = 0;
            List<int> frequencies = new List<int>();

            bool LoopFrequencies()
            {
                foreach (int change in Changes)
                {
                    frequency += change;
                    if (frequencies.Contains(frequency)) return true;
                    frequencies.Add(frequency);
                }

                return false;
            }

            bool same = false;
            while (!same)
            {
                same = LoopFrequencies();
            }

            return frequency;
        }

    }
}
