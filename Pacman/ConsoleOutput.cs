using System;

namespace Pacman
{
    public class ConsoleOutput : IOutput
    {
        public void DisplayTitle(string value, string textColour = "")
        {
            throw new NotImplementedException();
        }

        public void SetBackgroundColour(string value)
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), value, true);
        }

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value, string textColour = "")
        {
            if (textColour != "")
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textColour, true);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}