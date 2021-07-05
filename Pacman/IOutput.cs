namespace Pacman
{
    public interface IOutput
    {
        public void Write(string value);

        public void WriteLine(string value);

        public void DisplayTitle(string value);
    }
}