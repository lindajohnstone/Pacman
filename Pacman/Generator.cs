using System;
using System.Collections.Generic;

namespace Pacman
{
    public class Generator
    {
        public Grid CreateGrid(string filePath)
        {
            var file = new FileInput();
            var input = file.Read(filePath);
            return InputParser.ParseGrid(input);
        }

        public Grid CreateNextGrid(Grid previousGrid, List<IPlayer> players)
        {
            var nextGrid = previousGrid;
            foreach (var player in players)
            {
                var content = CellContent.None;
                if(player is Pacman)
                {
                    content = CellContent.Pacman;
                }
                else if (player is Ghost)
                {
                    content = CellContent.Ghost;
                }

                var previousCell = nextGrid.GetCell(content);
                var x = previousCell.Location.X;
                var y = previousCell.Location.Y;
                switch (player.Direction)
                {
                    case Direction.Up:
                        y = y - 1;
                        break;
                    case Direction.Down:
                        y = y + 1;
                        break;
                    case Direction.Left:
                        x = x - 1;
                        break;
                    case Direction.Right:
                        x = x + 1;
                        break;
                }
                var newLocation = new Location(x, y);
                var nextCell = nextGrid.GetCell(newLocation);

                if (player is Pacman && nextCell.Content == CellContent.Ghost)
                {
                    throw new GameOverException("Pacman ran into the ghost!");
                }
                if (player is Ghost && nextCell.Content == CellContent.Pacman)
                {
                    throw new GameOverException("Pacman has been eaten by the ghost!");
                }
                if (nextCell.State != CellState.Wall)
                {
                    nextGrid.UpdateLocationFor(content, newLocation);
                }
                // TODO: make it look like pacman is eaten - ghost replaces pacman 
                // prints ghost on top of pacman
                // need to check if the grid doesn't contain pacman, he has been eaten




                //TODO: pacman only
                // else if (nextCell.State == CellState.Dot)
                // {
                // TODO: scoring if cellstate === dots score++
                // }

                //TODO: lives - pacman dies and his position resets, but not the whole grid/score
            }
            return nextGrid;
        }
    }
}