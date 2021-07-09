namespace Pacman
{
    public interface IOutput
    {
        public void Write(string value);

        public void WriteLine(string value, string textColour = "");


        public void DisplayTitle(string value, string textColour = "");

        public void SetBackgroundColour(string value);

        public void Clear();
    }
}