using System;
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
        public Cell GetCell(Location location)
        {
            return Cells.FirstOrDefault(cell => cell.Location.X == location.X && cell.Location.Y == location.Y);
        }

        public Cell GetCell(CellContent content)
        {
            return Cells.FirstOrDefault(cell => cell.Content == content);
        }

        public void UpdateLocationFor(CellContent content, Location location)
        {
            var previous = GetCell(content);
            ReplaceCellContent(CellContent.None, previous);
            var next = GetCell(location);
            ReplaceCellContent(content, next);
        }

        private void ReplaceCellContent(CellContent newContent, Cell oldCell)
        {
            Cells.Remove(oldCell);
            var replacement = new Cell(newContent,
                oldCell.State,
                oldCell.Location.X,
                oldCell.Location.Y);
            Cells.Add(replacement);
        }
    }
}