namespace Pacman
{
    public class Ghost : IPlayer
    {
        public Direction Direction { get; private set; }

        // Kill
        // Find
        // Follow
        public void GetDirection()
        {
            Direction = Direction.Down; // TODO: fix
        }

        public void MakeMove()
        {
            throw new System.NotImplementedException();
        }
    }
}