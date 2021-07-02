using System;
using System.Collections.Generic;
using Xunit;

namespace Pacman.Tests
{
    public class InputParserShould
    {
        [Fact]
        public void testName()
        {
            var cells = new List<Cell>()
            {
                new Cell(CellContent.wall, 0, 0),
                new Cell(CellContent.wall, 0, 1),
                new Cell(CellContent.wall, 0, 2),
                new Cell(CellContent.wall, 0, 3),
                new Cell(CellContent.wall, 0, 4),
                new Cell(CellContent.wall, 1, 0),
                new Cell(CellContent.pacman, 1, 1),
                new Cell(CellContent.dots, 1, 2),
                new Cell(CellContent.dots, 1, 3),
                new Cell(CellContent.wall, 1, 4),
                new Cell(CellContent.wall, 2, 0),
                new Cell(CellContent.dots, 2, 1),
                new Cell(CellContent.wall, 2, 2),
                new Cell(CellContent.dots, 2, 3),
                new Cell(CellContent.wall, 2, 4),
                new Cell(CellContent.wall, 3, 0),
                new Cell(CellContent.empty, 3, 1),
                new Cell(CellContent.empty, 3, 2),
                new Cell(CellContent.ghost, 3, 3),
                new Cell(CellContent.wall, 3, 4),
                new Cell(CellContent.wall, 4, 0),
                new Cell(CellContent.wall, 4, 1),
                new Cell(CellContent.wall, 4, 2),
                new Cell(CellContent.wall, 4, 3),
                new Cell(CellContent.wall, 4, 4)
            };
            var expected = new Grid(5, 5, cells);
            var result = InputParser.ParseGrid("5,5\nWWWWW\nWPDDW\nWDWDW\nWEEGW\nWWWWW");

            Assert.True(PacmanHelper.GridsAreEqual(expected, result));
        }
    }
}