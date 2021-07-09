using System;
using System.Collections.Generic;
using Xunit;

namespace Pacman.Tests
{
    public class GridShould
    {
        [Fact]
        public void HaveSizeGreaterThan_WhenInitialized()
        {
            var width = 3;
            var height = 3;
            var cells = new List<Cell>();
            var grid = new Grid(width, height, cells, new Location(0,0));

            Assert.Equal(width, grid.Width);
            Assert.Equal(height, grid.Height);
        }
    }
}