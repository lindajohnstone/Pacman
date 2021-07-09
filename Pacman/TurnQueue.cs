using System;
using System.Collections.Generic;

namespace Pacman
{
    public class TurnQueue
    {
        // stores queue of player turns
        Queue<CellContent> _queue = new Queue<CellContent>();

        public TurnQueue(List<CellContent> players)
        {
            foreach (var player in players)
            {
                if (player != CellContent.none) _queue.Enqueue(player);
            }
        }

        public TurnQueue(TurnQueue source)
        {
            this._queue = new Queue<CellContent>(source._queue);
        }

        public CellContent GetCurrentPlayer()
        {
            return _queue.Peek();
        }

        public CellContent SetNextPlayer()
        {
            var lastPlayer = _queue.Dequeue();
            _queue.Enqueue(lastPlayer);
            return GetCurrentPlayer();
        }
    }
}