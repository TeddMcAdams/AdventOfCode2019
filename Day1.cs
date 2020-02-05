using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2019
{
    public class Day1
    {

        private List<int> input;
        public Day1()
        {
            input = File.ReadLines("Inputs/Day1input.txt")
                        .Select(int.Parse)
                        .ToList();

            // input = new List<int> { 100756 };
            
            Console.WriteLine("Day 1");
            Console.Write("Part1: ");
            Console.WriteLine(DetermineSumOfAllFuelRequired());
            Console.Write("Part2: ");
            Console.WriteLine(DetermineSumOfAllFuelRequiredRev2());
        }

        public int DetermineSumOfAllFuelRequired()
        {
            return input.Select(DetermineLaunchFuelRequiredForModule).Sum();
        }

        public int DetermineSumOfAllFuelRequiredRev2()
        {
            return input.Select(DetermineLaunchFuelRequiredForModuleRev2).Sum();
        }

        private int DetermineLaunchFuelRequiredForModule(int mass)
        {
           return (int)(Math.Floor(mass/3d)) - 2;
        }

        private int DetermineLaunchFuelRequiredForModuleRev2(int mass)
        {
            int totalFuel = 0;
            int fuel = 0;

            fuel = DetermineLaunchFuelRequiredForModule(mass);

            while(fuel > 0)
            {
                totalFuel += fuel;

                mass = fuel;

                fuel = DetermineLaunchFuelRequiredForModule(mass);
            }

            return totalFuel;
        }
    }
}