using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2019
{
    public class DayX
    {

        private List<int> input;
        public DayX()
        {
            input = File.ReadLines("Inputs/dayXinput.txt")
                        .Select(int.Parse)
                        .ToList();

            Console.WriteLine("DayX");
            Console.Write("Part1: ");
            Console.WriteLine();
            Console.Write("Part2: ");
            Console.WriteLine();
        }



    }
}