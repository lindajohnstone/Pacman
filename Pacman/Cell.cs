namespace Pacman
{
    public class Cell
    {
        public CellContent Content { get; private set; }

        public CellState State { get; private set; }

        public Location Location { get; private set; }

        public Cell(CellContent content, CellState state, int x, int y)
        {
            Content = content;
            State = state;
            Location = new Location(x, y);
        }
    }
}