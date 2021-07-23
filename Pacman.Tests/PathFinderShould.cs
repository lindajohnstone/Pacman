using System;
using Xunit;

namespace Pacman.Tests
{
    public class PathFinderShould
    {
        [Fact]
        public void FindBestPath_GivenValidInput()
        {
            var input = new FileInput();
            var path = "testData/pathfinder.txt";
            var result = input.Read(path);
            var grid = InputParser.ParseGrid(result);
            var ghost = new Location(0, 0);
            var pacman = new Location(10, 5);
            var pathfinder = new PathFinder();
            var direction = pathfinder.GetNextDirectionBasedOnBestPath(ghost, pacman, grid);

            Assert.Equal(Direction.Right, direction);
        }
    }
}