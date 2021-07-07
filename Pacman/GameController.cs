using Figgle;
using Spectre.Console;

namespace Pacman
{
    public class GameController
    {
        // puts the game together
        // giant text 'PACMAN' at beginning of game
        // same for game over
        // read key enter
        // call return level generator to 
        // wait for player to input key for game to start moving
        // read directional key - take from pacman
        // keep moving pacman until hits wall
        // manages - make move pacman, make move ghost
        // what triggers change? makemovepacman makemoveghost

        IInput _input;

        IOutput _output;

        public GameController(IInput input, IOutput output)
        {
            _input = input;
            _output = output;
        }

        public void Run()
        {
            _output.WriteLine("");
            _output.WriteLine(FiggleFonts.KeyboardSmall.Render("PACMAN"), "Yellow");
            _output.WriteLine(OutputConstants.Enter, "yellow");
            while (!_input.IsReadyToStart());
            var file = new FileInput();
            var input = file.Read("Pacman/grids/pacman-level-1.txt");
            var grid = InputParser.ParseGrid(input);
            _output.WriteLine(OutputFormatter.DisplayGrid(grid));

            // TODO this is where we're at 
        }

        
    }
}