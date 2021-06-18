namespace Pacman
{
    public class Grid
    {
        public int Width { get;  private set; }
        public int Height { get; private set; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
        }
        // TODO: grid needs a START place
    }
}