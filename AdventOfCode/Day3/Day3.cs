using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    public class Day3
    {
        private readonly List<Claim> _claims = new List<Claim>();
        private char[,] grid = new char[1000, 1000];
        
        struct Claim
        {
            // #123 @ 3,2: 5x4
            public int Id;
            public int LeftSpace;
            public int TopSpace;
            public int Width;
            public int Height;

            public Claim(string input)
            {
                input = input.Replace("#", String.Empty);
                input = input.Replace("@", String.Empty);
                input = input.Replace(",", " ");
                input = input.Replace(":", String.Empty);
                input = input.Replace("x", " ");
                input = input.Replace("  ", " ");
                var parts = input.Split(" ");
                int.TryParse(parts[0], out Id);
                int.TryParse(parts[1], out LeftSpace);
                int.TryParse(parts[2], out TopSpace);
                int.TryParse(parts[3], out Width);
                int.TryParse(parts[4], out Height);
            }
        }

        public Day3(IEnumerable<string> input)
        {
            foreach (var i in input)
            {
                _claims.Add(new Claim(i));
            }
            
            for (int w = 0; w < 1000; w++)
            {
                for (int h = 0; h < 1000; h++)
                {
                    grid[w, h] = '.';
                }
            }
            
            foreach (var claim in _claims)
            {
                for (int w = 0; w < claim.Width; w++)
                {
                    for (int h = 0; h < claim.Height; h++)
                    {
                        switch (grid[claim.LeftSpace + w, claim.TopSpace + h])
                        {
                            case 'x':
                                grid[claim.LeftSpace + w, claim.TopSpace + h] = 'd';
                                break;
                            case 'd':
                                break;
                            default:
                                grid[claim.LeftSpace + w, claim.TopSpace + h] = 'x';
                                break;
                        }
                    }
                }
            }
        }
        
        public void Output()
        {
            Console.WriteLine("Day 3");
            Console.WriteLine(Overlap());
            for (int w = 0; w < 20; w++)
            {
                for (int h = 0; h < 20; h++)
                {
                    Console.Write(grid[w, h]);
                }
                Console.Write("\n");
            }
        }

        private int Overlap()
        {
            // Count 'd' characters in grid
            int count = 0;
            for (int w = 0; w < 1000; w++)
            {
                for (int h = 0; h < 1000; h++)
                {
                    if (grid[w, h] == 'd') count++;
                }
            }

            return count;
        }
    }
}