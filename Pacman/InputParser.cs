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
            var cells = new List<Cell>();

            for (int i = 1; i < inputLines.Length; i++)
            {
                for (int j = 0; j < inputLines[i].Length; j++)
                {
                    var cellContents = CellContent.empty;
                    switch (inputLines[i][j])
                    {
                        case 'W':
                            cellContents = CellContent.wall;
                            break;
                        case 'P':
                            cellContents = CellContent.pacman;
                            break;
                        case 'G':
                            cellContents = CellContent.ghost;
                            break;
                        case 'D':
                            cellContents = CellContent.dots;
                            break;
                    }
                    cells.Add(new Cell(cellContents, i - 1, j));
                }
            }
        return new Grid(Int32.Parse(dimensions[0]), Int32.Parse(dimensions[1]), cells);
        }
    }
}