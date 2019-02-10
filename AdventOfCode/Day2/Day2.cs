using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class Day2
    {
        private IEnumerable<string> BoxIDs { get; }

        public Day2(IEnumerable<string> boxIDs) => BoxIDs = boxIDs;

        public int Checksum()
        {
            /*
             * Count how many have exactly 2 of any letter
             * Count how many have exactly 3 of any letter
             * Multiply the 2 counts
             */
            int count2 = 0;
            int count3 = 0;
            
            foreach(var boxID in BoxIDs)
            {
                var d = boxID.GroupBy(x => x).ToDictionary(x => x, x => x.Count());
                if (d.ContainsValue(3)) count3++;
                if (d.ContainsValue(2)) count2++;
            }
            
            return count2 * count3;
        }

        public List<char> CommonLetters()
        {
            List<char> commonLetters = new List<char>();
            int len = 0; // length of word
            
            var l = BoxIDs.ToList();
            l.Sort();

            for (int i = 0; i < l.Count; i++)
            {
                len = l[i].Length;
                
                for (int j = 0; j < len; j++)
                {
                    if (l[i + 1][j] == l[i][j])
                    {
                        commonLetters.Add(l[i][j]);
                    }
                }

                if ((commonLetters.Count) == len - 1)
                {
                    break;
                } else commonLetters.Clear();
            }

            return commonLetters;
        }
    }
}