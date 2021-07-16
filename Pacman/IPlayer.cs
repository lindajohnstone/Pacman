namespace Pacman
{
    public interface IPlayer
    {
        void GetDirection(Grid grid);
        Direction Direction { get; }
    }
}