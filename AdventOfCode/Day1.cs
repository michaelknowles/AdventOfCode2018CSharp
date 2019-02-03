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
    }
}
