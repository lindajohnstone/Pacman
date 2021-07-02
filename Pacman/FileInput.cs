using System.IO;

namespace Pacman
{
    public class FileInput : IInput
    {
        public string Read(string input)
        {
            return File.ReadAllText(input);
        }
    }
}