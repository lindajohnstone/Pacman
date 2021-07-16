using System;
using System.Collections.Generic;

namespace Pacman
{
    public static class InputParser
    {
        public static Grid ParseGrid(string input)
        {
            var start = new Location(0, 0);
            var inputLines = input.Split("\n");
            var dimensions = inputLines[0].Split(",");
            var cells = new List<Cell>();

            for (int y = 1; y < inputLines.Length; y++)
            {
                for (int x = 0; x < inputLines[y].Length; x++)
                {
                    var cellContents = CellContent.None;
                    var cellState = CellState.Empty;
                    switch (inputLines[y][x])
                    {
                        case 'W':
                            cellState = CellState.Wall;
                            break;
                        case 'P':
                            cellContents = CellContent.Pacman;
                            start = new Location(x, y - 1);
                            break;
                        case 'G':
                            cellContents = CellContent.Ghost;
                            break;
                        case 'D':
                            cellState = CellState.Dot;
                            break;
                        case 'H':
                            cellState = CellState.GhostHome;
                            break;
                    }
                    cells.Add(new Cell(cellContents, cellState, x, y - 1));
                }
            }
        return new Grid(Int32.Parse(dimensions[0]), Int32.Parse(dimensions[1]), cells, start);
        }
    }
}