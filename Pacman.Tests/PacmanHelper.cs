using System;
using System.Collections.Generic;
using System.Linq;

namespace Pacman.Tests
{
    public class PacmanHelper
    {
        public static bool GridsAreEqual(Grid grid1, Grid grid2)
        {
            if (grid1 == null || grid2 == null) return false;
            if (grid1.Width != grid2.Width) return false;
            if (grid1.Height != grid2.Height) return false;
            if (!ListsOfCellsAreEqual(grid1.Cells, grid2.Cells)) return false;
            return true;
        }

        public static bool ListsOfCellsAreEqual(List<Cell> cells1, List<Cell> cells2)
        {
            if (cells1 == null || cells1 == null) return false;
            if (cells1.Count != cells2.Count) return false;
            for (var i = 0; i < cells1.Count; i++)
            {
                if (!CellsAreEqual(cells1[i], cells2[i])) return false;
            }
            return true;
        }

        public static bool CellsAreEqual(Cell cell1, Cell cell2)
        {
            var isLocationSame = LocationsAreEqual(cell1.Location, cell2.Location);
            var isCellContentSame = cell1.Content == cell2.Content;
            return isCellContentSame && isLocationSame;
        }

        public static bool LocationsAreEqual(Location location1, Location location2)
        {
            if (location1.X == location2.X && location1.Y == location2.Y) return true;
            return false;
        }
    }
}