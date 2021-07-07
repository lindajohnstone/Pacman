using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    public static class OutputFormatter
    {
        public static string DisplayGrid(Grid grid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int x = 1; x < grid.Height; x++)
            {
                for (int y = 0; y < grid.Width; y++)
                {
                    var location = new Location(x, y);
                    var cell = grid.GetCellAtLocation(location);
                    var cellDisplay = "";
                    switch (cell.State)
                    {
                        case CellState.wall:
                            cellDisplay += OutputConstants.wall;
                            break;
                        case CellState.empty:
                            cellDisplay += OutputConstants.empty;
                            break;
                        case CellState.dots:
                            cellDisplay += OutputConstants.dots;
                            break;
                    }
                    switch (cell.Content)
                    {
                        case CellContent.pacman:
                            cellDisplay += OutputConstants.pacman;
                            break;
                        case CellContent.ghost:
                            cellDisplay += OutputConstants.ghost;
                            break;
                    }
                    stringBuilder.Append(cellDisplay);
                }
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }
    }
}