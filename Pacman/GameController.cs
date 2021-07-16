using System;
using System.Collections.Generic;
using Figgle;
using Spectre.Console;
using System.Linq;
using System.Threading;

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
            // print title
            _output.WriteLine("");
            _output.WriteLine(FiggleFonts.KeyboardSmall.Render("PACMAN"), "Yellow");
            _output.WriteLine(OutputConstants.Enter, "yellow");
            while (!_input.IsReadyToStart());

            // print level
            var generator = new Generator();
            var grid = generator.CreateGrid(Levels.Level1);
            _output.Clear();
            _output.WriteLine(OutputFormatter.DisplayGrid(grid), "White");
            var pacman = new Pacman(_input);
            var ghost = new Ghost();
            var players = new List<IPlayer>()
            {
                pacman,
                ghost
            };
            var gameOver = false;
            while (!gameOver)
            {
                foreach (var player in players)
                {
                    player.GetDirection(grid);
                }
                try
                {
                    grid = generator.CreateNextGrid(grid, players);
                    Thread.Sleep(400);
                    _output.Clear();
                    _output.WriteLine(OutputFormatter.DisplayGrid(grid), "White");
                }
                catch (GameOverException e)
                {
                    _output.Clear();
                    _output.WriteLine(FiggleFonts.KeyboardSmall.Render("GAME OVER"), "Red");
                    _output.WriteLine(e.Message, "White");
                    gameOver = true;
                }
            }
            // pacman has turn
            // check for input on pacman's direction
            // if given, set pacman's new direction
            // move pacman one cell in set direction

            // ghost has turn
            // ghost decide what direction to move (using distance, random, etc?)
            // move ghost
            // if cell ghost wants to move to contains pacman- END ROUND
            // does pacman have lives left? -keep going
            // no? GAME OVER!

            // check conditions for end:
            // are all the dots gone?


            //  []][PG][ ]
        }

        private bool EndGame()
        {
            return false;
        }
    }
}