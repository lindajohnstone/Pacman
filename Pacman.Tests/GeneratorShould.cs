using System;
using System.Collections.Generic;
using Xunit;

namespace Pacman.Tests
{
    public class GeneratorShould
    {
        [Fact]
        public void CreateInitialGrid_WithPacman()
        {
            var generator = new Generator();
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
            var expected = new Grid(3, 3, cells);
            var result = generator.CreateGrid();

            Assert.Equal(expected, result);
        }
    }
}