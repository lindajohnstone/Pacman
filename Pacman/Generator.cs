using System;
using System.Collections.Generic;

namespace Pacman
{
    public class Generator
    {
        public Grid CreateGrid(string filePath)
        {
            var file = new FileInput();
            var input = file.Read(filePath);
            return InputParser.ParseGrid(input);
        }

        public void CreateNextGrid(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}