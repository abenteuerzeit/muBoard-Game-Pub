using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muBoard_Game_Pub.Games
{
    public class Puzzle : Game
    {
        protected override int MaxPlayers { get => base.MaxPlayers; set => base.MaxPlayers = value; }
        protected override int MinPlayers { get => base.MinPlayers; set => base.MinPlayers = 1; }

        public Puzzle(TimeSpan playingTime, Complexity complexity, int minPlayers = 1, int maxPlayers = 1) : base(playingTime, complexity, minPlayers, maxPlayers)
        {
        }


    }
}
