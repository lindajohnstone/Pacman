using System;

namespace Pacman
{
    public class ConsoleOutput : IOutput
    {
        public void DisplayTitle(string value)
        {
            throw new NotImplementedException();
        }

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}