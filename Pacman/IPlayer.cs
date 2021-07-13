namespace Pacman
{
    public interface IPlayer
    {
        void GetDirection();
        void MakeMove();
        Direction Direction { get; }
    }
}