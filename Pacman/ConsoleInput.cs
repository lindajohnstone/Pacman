using System;

namespace Pacman
{
    public class ConsoleInput : IInput
    {
        public string Read(string v)
        {
            throw new NotImplementedException();
        }

        public bool IsReadyToStart()
        {
            if (Console.KeyAvailable) 
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter) return true;
            }
            return false;
        }   

        public Direction GetDirection()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        return Direction.Up;
                    case ConsoleKey.DownArrow:
                        return Direction.Down;
                    case ConsoleKey.LeftArrow:
                        return Direction.Left;
                    case ConsoleKey.RightArrow:
                        return Direction.Right;
                }
            }
            return Direction.NoChange;
        }
    }
}