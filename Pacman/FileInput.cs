using System.IO;

namespace Pacman
{
    public class FileInput : IInput
    {
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