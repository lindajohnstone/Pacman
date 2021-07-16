using System.Collections.Generic;
using System.Text;

namespace Pacman
{
    public static class OutputFormatter
    {
        public static string DisplayGrid(Grid grid)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int y = 0; y < grid.Height; y++)
            {
                for (int x = 0; x < grid.Width; x++)
                {
                    var location = new Location(x, y);
                    var cell = grid.GetCell(location);
                    var cellDisplay = "";
                    switch (cell.State)
                    {
                        case CellState.Wall:
                            cellDisplay = OutputConstants.wall;
                            break;
                        case CellState.Empty:
                            cellDisplay = OutputConstants.empty;
                            break;
                        case CellState.Dot:
                            cellDisplay = OutputConstants.dots;
                            break;
                    }
                    switch (cell.Content)
                    {
                        case CellContent.Pacman:
                            cellDisplay = OutputConstants.pacman;
                            break;
                        case CellContent.Ghost:
                            cellDisplay = OutputConstants.ghost;
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