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
    }
}