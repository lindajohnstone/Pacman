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

        public bool HasDirectionChanged()
        {
             return true;
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
                        //
                        break;
                    case ConsoleKey.LeftArrow:
                        //
                        break;
                    case ConsoleKey.RightArrow:
                        //
                        break;
                }
            }
            return Direction.NoChange;
        }
    }
}