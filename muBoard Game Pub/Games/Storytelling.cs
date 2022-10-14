using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muBoard_Game_Pub.Games
{
    public sealed class Storytelling : Game
    {
        private Storytelling(TimeSpan playingTime, Complexity complexity, int minPlayers, int maxPlayers) : base(playingTime, complexity, minPlayers, maxPlayers)
        { }

        private static Storytelling? instance;
        public static Storytelling GetInstance(TimeSpan playingTime, Complexity complexity, int minPlayers, int maxPlayers)
        {
            return instance ??= new Storytelling(playingTime, complexity, minPlayers, maxPlayers);
        }

        protected override int MaxPlayers
        {
            get => base.MaxPlayers; set
            {
                if (value >= MinPlayers)
                {
                    base.MaxPlayers = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Max players should be greater than min players");
                }
            }
        }
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

    }
}
