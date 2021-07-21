using System;

namespace Pacman
{
    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Cost { get; set; }
        public int Distance { get; set; }
        public int CostDistance => Cost + Distance;
        public Tile Parent { get; set; }

        public Tile(Location location)
        {
            X = location.X;
            Y = location.Y;
        }
        public Tile(int x, int y, Tile parent, int cost)
        {
            X = x;
            Y = y;
            Parent = parent;
            Cost = cost;
        }

        //The distance is essentially the estimated distance, ignoring walls to our target. 
        //So how many tiles left and right, up and down, ignoring walls, to get there. 
        public void SetDistance(int targetX, int targetY)
        {
            this.Distance = Math.Abs(targetX - X) + Math.Abs(targetY - Y);
        }
    }
}