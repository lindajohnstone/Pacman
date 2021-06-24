using System;
using System.Collections.Generic;

namespace Pacman
{
    public class Generator
    {
        public Grid CreateGrid()
        {
            List<Cell> cells = new List<Cell>()
            {
                new Cell(CellContent.wall, 0, 0),
                new Cell(CellContent.wall, 0, 1),
                new Cell(CellContent.wall, 0, 2),
                new Cell(CellContent.wall, 0, 3),
                new Cell(CellContent.wall, 1, 0),
                new Cell(CellContent.pacman, 1, 1),
                new Cell(CellContent.wall, 1, 2),
                new Cell(CellContent.wall, 2, 0),
                new Cell(CellContent.wall, 2, 1),
                new Cell(CellContent.wall, 2, 2)
            };

            return new Grid(3, 3, cells);
        }
    }
}