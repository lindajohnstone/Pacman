namespace Pacman
{
    public class Pacman : IPlayer
    {
        // - pacman has a direction
        // - pacman moves on each tick
        // - user can rotate pacman
        // - pacman eats dots
        // - pacman wraps around
        // - pacman stops on wall
        // - pacman will not rotate into a wall
        // Powerups
        // Lives - default 3
        // v = up
        // < = right
        // > = left
        // ^ = down 
        // arrow keys for movement
        IInput _input;
        public Pacman(IInput input)
        {
            _input = input;
        }
        public void GetDirection()
        {
            throw new System.NotImplementedException();
        }

        public void MakeMove()
        {
            throw new System.NotImplementedException();
        }
    }
}