using System.Collections.Generic;
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
            Regex match2 = new Regex(@"([a-z]{1}).*?\1", RegexOptions.IgnoreCase);
            Regex match3 = new Regex(@"([a-z]{1}).*?\1.*?\1", RegexOptions.IgnoreCase);
            
            foreach (var boxID in BoxIDs)
            {
                if (match3.IsMatch(boxID))
                {
                    count3++;
                } else if (match2.IsMatch(boxID))
                {
                    count2++;
                }
            }

            return count2 * count3;
        }
    }
}