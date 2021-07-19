using System;
using System.Collections.Generic;

namespace Pacman
{
    public class Ghost : IPlayer
    {
        public Direction Direction { get; private set; }
        public bool IsHome { get; private set; }

        public Ghost()
        {   
            IsHome = true;
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
        public void GetDirection(Grid grid)
        {
            var pacman = grid.GetCell(CellContent.Pacman).Location;
            var ghost = grid.GetCell(CellContent.Ghost).Location;
            var home = grid.GetCell(CellState.GhostHome).Location;

            var target = IsHome ? home : pacman;
            var moves = GetPotentialMoves(ghost);
            Direction = DecideBestMove(moves, target);
            // TODO: Pathfinding to make a clever ghost 
            // https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/
        }

        private Direction DecideBestMove(List<Location> moves, Location target)
        {
            throw new NotImplementedException();
        }

        private List<Location> GetPotentialMoves(Location currentLocation)
        {
            var moves = new List<Location>();
            for (int offset = -1; offset <= 1; offset += 2)
            {
                moves.Add(new Location(currentLocation.X + offset, currentLocation.Y));
                moves.Add(new Location(currentLocation.X, currentLocation.Y + offset));
            }
            return moves;
        }
    }
}