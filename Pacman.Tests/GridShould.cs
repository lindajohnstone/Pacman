using System;
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
            var grid = new Grid(width, height);

            Assert.Equal(width, grid.Width);
            Assert.Equal(height, grid.Height);
        }

        
    }
}