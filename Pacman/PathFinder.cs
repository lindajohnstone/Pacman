using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Pacman
{
    public class PathFinder
    {
        public Direction GetNextDirectionBasedOnBestPath(Location start, Location finish, Grid grid)
        {
            var startTile = new Tile(start);
            var finishTile = new Tile(finish);

            var activeTiles = new List<Tile>();
            var visitedTiles = new List<Tile>();
            startTile.SetDistance(finish.X, finish.Y);
            activeTiles.Add(startTile);
            
            while (activeTiles.Any())
            {
                //Console.WriteLine($"Active Tiles: {activeTiles.Count}");
                //Console.WriteLine($"Visited Tiles: {visitedTiles.Count}");
                
                var checkTile = activeTiles.OrderBy(x => x.CostDistance).First();
                //Console.WriteLine($"Currently looking at the tile at location {checkTile.X},{checkTile.Y}");

                if (checkTile.X == finish.X && checkTile.Y == finish.Y)
                {
                    var tile = checkTile;
                    var bestPath = new List<Tile>();
                    while (tile.Parent != null)
                    {
                        bestPath.Add(tile);
                        tile = tile.Parent;
                    }
                    
                    var nextMove = bestPath[^1];
                    Console.WriteLine(nextMove.X);
                    Console.WriteLine(nextMove.Y);

                    var xChange = startTile.X - nextMove.X;
                    Console.WriteLine($"{startTile.X} - {nextMove.X}");
                    Console.WriteLine($"xChange: {xChange}");
                    var yChange = startTile.Y - nextMove.Y;
                    Console.WriteLine($"{startTile.Y} - {nextMove.Y}");
                    Console.WriteLine($"yChange: {yChange}");

                    switch(xChange)
                    {
                        case 1:
                            return Direction.Left;
                        case -1:
                            return Direction.Right;
                    }

                    switch(yChange)
                    {
                        case 1:
                            return Direction.Up;
                        case -1:
                            return Direction.Down;
                    }
                    break;
                }

                visitedTiles.Add(checkTile);
                activeTiles.Remove(checkTile);

                var walkableTiles = GetWalkableTiles(grid, checkTile, finishTile);

                foreach (var walkableTile in walkableTiles)
                {
                    //Console.WriteLine("---------");
                    //Console.WriteLine($"Walkable Tile: {walkableTile.X},{walkableTile.Y}");
                    //We have already visited this tile so we don't need to do so again!
                    if (visitedTiles.Any(x => x.X == walkableTile.X && x.Y == walkableTile.Y))
                    {
                        //Console.WriteLine("I've seen this tile");
                        continue;
                    }

                    //It's already in the active list, but that's OK, 
                    //maybe this new tile has a better value (e.g. We might zigzag earlier 
                    //but this is now straighter). 
                    if (activeTiles.Any(x => x.X == walkableTile.X && x.Y == walkableTile.Y))
                    {
                        var existingTile = activeTiles.First(x => x.X == walkableTile.X && x.Y == walkableTile.Y);
                        if (existingTile.CostDistance > checkTile.CostDistance)
                        {
                            activeTiles.Remove(existingTile);
                            activeTiles.Add(walkableTile);
                        }
                    }
                    else
                    {
                        //We've never seen this tile before so add it to the list.
                        //Console.WriteLine("oh wow~ a new tile!");
                        activeTiles.Add(walkableTile);
                    }
                }
            }
            Thread.Sleep(2000);
            return Direction.NoChange;
        }

        private static List<Tile> GetWalkableTiles(Grid grid, Tile currentTile, Tile targetTile)
        {
            //TODO: Moves list is wrong- is this getting the available tiles correctly?
            var possibleTiles = new List<Tile>()
            {
                new Tile(currentTile.X, currentTile.Y - 1, currentTile, currentTile.Cost + 1 ),
                new Tile(currentTile.X, currentTile.Y + 1, currentTile, currentTile.Cost + 1),
                new Tile(currentTile.X - 1, currentTile.Y, currentTile, currentTile.Cost + 1),
                new Tile(currentTile.X + 1, currentTile.Y, currentTile, currentTile.Cost + 1),
            };

            possibleTiles.ForEach(tile => tile.SetDistance(targetTile.X, targetTile.Y));

            var maxX = grid.Width - 1;
            var maxY = grid.Height - 1;

            return possibleTiles
                    .Where(tile => tile.X >= 0 && tile.X <= maxX)
                    .Where(tile => tile.Y >= 0 && tile.Y <= maxY)
                    .Where(tile => grid.GetCell(new Location(tile.X, tile.Y)).State != CellState.Wall)
                    .ToList();
        }
    }
}