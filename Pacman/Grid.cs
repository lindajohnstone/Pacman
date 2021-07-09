using System.Collections.Generic;
using System.Linq;

namespace Pacman
{
    public class Grid
    {
        public int Width { get;  private set; }
        public Location StartLocation { get; private set; }
        public int Height { get; private set; }

        public List<Cell> Cells { get;  private set; }

        public Grid(int width, int height, List<Cell> cells, Location start)
        {
            Width = width;
            Height = height;
            Cells = cells;
            StartLocation = start;
        }
        public Cell GetCellAtLocation(Location location)
        {
            return Cells.FirstOrDefault(cell => cell.Location.X == location.X && cell.Location.Y == location.Y);
        }
    }
}