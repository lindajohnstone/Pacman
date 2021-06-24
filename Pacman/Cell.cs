namespace Pacman
{
    public class Cell
    {
        public CellContent Content { get; private set; }

        public Location Location { get; private set; }

        public Cell(CellContent content, int x, int y)
        {
            Content = content;
            Location = new Location(x, y);
        }
    }
}