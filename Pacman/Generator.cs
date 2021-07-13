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
                if(player is Pacman)
                {
                    var cell = nextGrid.GetCell(CellContent.pacman);
                    // switch on the direction
                    // case up: x, y-1
                    // case down: x, y+1
                    // case left: x-1, y
                    // case right: x+1, y
                    // var newlocation = nextGrid.FindCell(cell.x, cell.y)
                    // if newlocation == wall return;
                    // else set pacman here
                    // if newlocation is ghost?? 
                    // throw new PacmanDeadException("GHOST IS HERE!!!!");
                    // TODO: scoring if cellstate === dots score++
                }
                else if (player is Ghost)
                {

                }
            }
            return nextGrid;
        }
    }
}