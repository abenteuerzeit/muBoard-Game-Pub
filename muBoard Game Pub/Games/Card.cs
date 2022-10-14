using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muBoard_Game_Pub.Games
{
    public class Card : Game
    {
        protected override int MaxPlayers { get => base.MaxPlayers; set => base.MaxPlayers = value; }
        protected override int MinPlayers
        {
            get => base.MinPlayers;
            set
            {
                if (value > 1)
                {
                    base.MinPlayers = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Cannot start alone. Add more players");
                }
            }
        }


        public Card(TimeSpan playingTime, Complexity complexity, int minPlayers, int maxPlayers) : base(playingTime, complexity, minPlayers, maxPlayers)
        {
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
        }


    }
}
