using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    class Day1
    {
        private int frequency = 0;
        private readonly string[] changes = System.IO.File.ReadAllLines("Day1-Input.txt");

        public int GetFrequency()
        {
            foreach(string change in changes) {
                int number;
                bool converted = Int32.TryParse(change, out number);
                frequency += number;
            }

            return frequency;
        }

        public int GetSameFrequency()
        {
            List<int> numbers = new List<int>();
            int number = 0;

            foreach (string change in changes)
            {
                bool converted = Int32.TryParse(change, out number);
                frequency += number;
                if (numbers.Contains(number))
                {
                    return number;
                }
                numbers.Add(frequency);
            }
            return number;
        }

    }
}
