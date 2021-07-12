using System;
using System.Collections.Generic;

namespace Pacman
{
    public class TurnQueue
    {
        // stores queue of player turns
        Queue<IPlayer> _queue = new Queue<IPlayer>();

        public TurnQueue(List<IPlayer> players)
        {
            foreach (var player in players)
            {
                _queue.Enqueue(player);
            }
        }

        public TurnQueue(TurnQueue source)
        {
            this._queue = new Queue<IPlayer>(source._queue);
        }

        public IPlayer GetCurrentPlayer()
        {
            return _queue.Peek();
        }

        public IPlayer SetNextPlayer()
        {
            var lastPlayer = _queue.Dequeue();
            _queue.Enqueue(lastPlayer);
            return GetCurrentPlayer();
        }
    }
}