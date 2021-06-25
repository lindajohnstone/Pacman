using System;
using System.Collections.Generic;

namespace Pacman
{
    public static class InputParser
    {
        public static Grid ParseGrid(string input)
        {
            var inputLines = input.Split("\n");
            var dimensions = inputLines[0].Split(",");
            // TODO: return values from string
            
            return new Grid(Int32.Parse(dimensions[0]), Int32.Parse(dimensions[1]), new List<Cell>());
        }
    }
}