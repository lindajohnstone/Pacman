using System;

namespace Pacman
{
    public interface IInput
    {
        public string Read(string v);
        bool IsReadyToStart();
        Direction GetDirection();
    }
}