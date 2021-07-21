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

        // Kill
        // Find
        // Follow
        //  . .  . . . . .  p p p p p |
        //  P . . . . . . . .         |
        //  ----------------------    |
        //  | G        |       |      |
        //             |       |      |
        //  |          ----B----      |
        //                 
        public void GetDirection(Grid grid) //TODO: add writelines to see what ghost is doing
        {
            var pacman = grid.GetCell(CellContent.Pacman).Location;
            var ghost = grid.GetCell(CellContent.Ghost).Location;

            var direction = PathFinder.GetNextDirectionBasedOnBestPath(pacman, ghost, grid);
            if (direction != Direction.NoChange)
            {
                Direction = direction;
            }            
            // TODO: Pathfinding to make a clever ghost 
            // https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/
        }

        // private List<Location> GetPotentialMoves(Location currentLocation)
        // {
        //     var moves = new List<Location>();
        //     for (int offset = -1; offset <= 1; offset += 2)
        //     {
        //         moves.Add(new Location(currentLocation.X + offset, currentLocation.Y));
        //         moves.Add(new Location(currentLocation.X, currentLocation.Y + offset));
        //     }
        //     return moves;
        // }
    }
}