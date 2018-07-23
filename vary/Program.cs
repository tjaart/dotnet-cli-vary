using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using McMaster.Extensions.CommandLineUtils;

namespace vary
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "vary";
            app.HelpOption("-?|-h|--help");


            app.Command("byint", (command) =>
            {
                var templateArg = command.Argument("[template]", "template string");

                command.OnExecute(() =>
                {
                    var tmpl = templateArg.Value;

                    var matches = Regex.Matches(tmpl, @"\[\[([0-9]+\-[0-9]+)\]\]");
                    var x = matches.First();

                    var ranges = new List<(int start, int end)>();

                    foreach (var match in matches)
                    {
                        var range = ((Match) match).Groups[1].Value;

                        var rangeStart = int.Parse(range.Split('-')[0]);
                        var rangeEnd = int.Parse(range.Split('-')[1]);
                        ranges.Add((rangeStart, rangeEnd));
                    }

                    var resultStr = tmpl;

                    ReplaceForTuple(ranges[0].start, ranges[0].end, resultStr, ranges);
                });
            });

            app.Execute(args);
        }

        private static void ReplaceForTuple(int start, int end, string result, List<(int start, int end)> remaining)
        {
            for (int i = start; i <= end; i++)
            {
                var resultStr = result.Replace($"[[{start}-{end}]]", i.ToString());


                if (remaining.Any() && remaining.Count > 1)
                {
                    var next = remaining[1];
                    ReplaceForTuple(next.start, next.end, resultStr, remaining.Skip(1).ToList());
                }
                else
                {
                    Console.WriteLine(resultStr);
                }
            }
        }
    }
}