using System;
using System.Collections.Generic;

namespace Pacman
{
    public class Ghost : IPlayer
    {
        public Direction Direction { get; private set; }
        public PathFinder PathFinder { get; private set; }

        public Ghost()
        {   
            PathFinder = new PathFinder();
        }
               
        public void GetDirection(Grid grid) 
        {
            var pacman = grid.GetCell(CellContent.Pacman).Location;
            var ghost = grid.GetCell(CellContent.Ghost).Location;
            
            var direction = PathFinder.GetNextDirectionBasedOnBestPath(ghost, pacman, grid);
            if (direction != Direction.NoChange)
            {
                Direction = direction;
            }
        }        
    }
}