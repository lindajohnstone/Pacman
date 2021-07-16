namespace Pacman
{
    public class Ghost : IPlayer
    {
        public Direction Direction { get; private set; }

        //AtHome == false;
        // Kill
        // Find
        // Follow
        //  . .  . . . . .  p p p p p         |
        //  . . . . . . . . .        |
        //  ----------------------   |
        //            |       |      |
        //            |       |      |
        //            ----B----      |
        //                 G
        public void GetDirection(Grid grid)
        {
            var pacman = grid.GetCell(CellContent.Pacman).Location;
            var ghost = grid.GetCell(CellContent.Ghost).Location;
            Direction = Direction.Down; // TODO: fix
        }
    }
}