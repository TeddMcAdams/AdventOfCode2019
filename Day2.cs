using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2019
{
    public class Day2
    {

        private List<int> input;
        public Day2()
        {
            input = File.ReadLines("Inputs/Day2input.txt")
                        .Select(int.Parse)
                        .ToList();

            Console.WriteLine("Day2");
            Console.Write("Part1: ");
            Console.WriteLine();
            Console.Write("Part2: ");
            Console.WriteLine();
        }



    }
}