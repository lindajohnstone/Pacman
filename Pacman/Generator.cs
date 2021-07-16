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
                
                if(nextCell.State != CellState.Wall)
                {
                    nextGrid.UpdateLocationFor(content, newLocation);
                }


                //TODO: pacman only
                // else if (nextCell.State == CellState.Dot)
                // {
                //     // TODO: scoring
                // }
                // else if (nextCell.Content == CellContent.Ghost)
                // {
                //     // Pacman dies TODO: lives

                // }


                
                // if newlocation == wall return;
                // else set pacman here
                // if newlocation is ghost?? 
                // throw new PacmanDeadException("GHOST IS HERE!!!!");
                // TODO: scoring if cellstate === dots score++
                
            }
            return nextGrid;
        }
    }
}