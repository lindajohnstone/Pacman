using System;
using System.Collections.Generic;
using Xunit;

namespace Pacman.Tests
{
    public class InputParserShould
    {
        [Fact]
        public void ReturnAGrid_GivenStringInput()
        {
            var cells = new List<Cell>()
            {
                new Cell(CellContent.None, CellState.Wall,0, 0),
                new Cell(CellContent.None, CellState.Wall, 0, 1),
                new Cell(CellContent.None, CellState.Wall, 0, 2),
                new Cell(CellContent.None, CellState.Wall, 0, 3),
                new Cell(CellContent.None, CellState.Wall, 0, 4),
                new Cell(CellContent.None, CellState.Wall, 1, 0),
                new Cell(CellContent.Pacman, CellState.Empty, 1, 1),
                new Cell(CellContent.None, CellState.Dot, 1, 2),
                new Cell(CellContent.None, CellState.Dot, 1, 3),
                new Cell(CellContent.None, CellState.Wall, 1, 4),
                new Cell(CellContent.None, CellState.Wall, 2, 0),
                new Cell(CellContent.None, CellState.Dot, 2, 1),
                new Cell(CellContent.None, CellState.Wall, 2, 2),
                new Cell(CellContent.None, CellState.Dot, 2, 3),
                new Cell(CellContent.None, CellState.Wall, 2, 4),
                new Cell(CellContent.None, CellState.Wall, 3, 0),
                new Cell(CellContent.None, CellState.Empty, 3, 1),
                new Cell(CellContent.None, CellState.Empty, 3, 2),
                new Cell(CellContent.Ghost, CellState.Empty, 3, 3),
                new Cell(CellContent.None, CellState.Wall, 3, 4),
                new Cell(CellContent.None, CellState.Wall, 4, 0),
                new Cell(CellContent.None, CellState.Wall, 4, 1),
                new Cell(CellContent.None, CellState.Wall, 4, 2),
                new Cell(CellContent.None, CellState.Wall, 4, 3),
                new Cell(CellContent.None, CellState.Wall, 4, 4)
            };
            var expected = new Grid(5, 5, cells, new Location(1,1));

            var result = InputParser.ParseGrid("5,5\nWWWWW\nWPDDW\nWDWDW\nWEEGW\nWWWWW");

            Assert.True(PacmanHelper.GridsAreEqual(expected, result));
        }
    }
}