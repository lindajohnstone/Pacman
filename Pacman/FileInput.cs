using System.IO;

namespace Pacman
{
    public class FileInput : IInput
    {
        public Direction GetDirection()
        {
            throw new System.NotImplementedException();
        }

        public bool IsReadyToStart()
        {
            throw new System.NotImplementedException();
        }

        public string Read(string input)
        {
            return File.ReadAllText(input);
        }
    }
}