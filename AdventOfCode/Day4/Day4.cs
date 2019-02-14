using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day4
    {
        private readonly List<Event> _events;
        
        struct Event
        {
            // [YYYY-MM-DD HH:MM] Guard #x begins shift
            // [YYYY-MM-DD HH:MM] wakes up
            // [YYYY-MM-DD HH:MM] falls asleep

            public readonly string Date;
            public readonly string Time;
            public readonly string Action;

            public Event(string input)
            {
                input.Replace("[", String.Empty);
                input.Replace("]", String.Empty);
                var parts = input.Split(" ");
                Date = parts[0];
                Time = parts[1];
                Action = String.Join(" ", parts, 2, parts.Length - 3);
            }
        }

        struct Day
        {
            public readonly string Date;
            public readonly List<string> Actions;
            public int Guard;

            public Day(string date, List<string> actions)
            {
                Date = date;
                Actions = actions;
                int.TryParse(
                    Actions[0]
                    .Split(" ")[1]
                    .Replace("#", String.Empty),
                    out Guard);
            }
        }

        public Day4(IEnumerable<string> input)
        {
            // build chronological events from input
            List<Event> inputs = new List<Event>();
            foreach (var i in input)
            {
                inputs.Add(new Event(i));
            }
            var _events = inputs.OrderBy(i => i.Date + i.Time);
            
            // group by day
            // TODO: Test that this works correctly
            var days = _events.GroupBy(
                i => i.Date,
                i => i.Action,
                (key, g) => new
                {
                    Date = key,
                    Actions = g.ToList()
                });
        }
    }
}