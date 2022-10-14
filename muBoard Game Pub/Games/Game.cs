using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace muBoard_Game_Pub.Games
{
    public enum Complexity
    {
        easy,
        medium,
        hard
    }
    public abstract class Game
    {

        protected TimeSpan PlayingTime { get; set; }
        protected Complexity Complexity { get; set; }
        protected virtual int MinPlayers { get; set; }
        protected virtual int MaxPlayers { get; set; }

        //public Player[] Players { get; set; }
        public List<Player> Players { get; set; }

        public Game(TimeSpan playingTime, Complexity complexity, int minPlayers, int maxPlayers)
        {
            PlayingTime = playingTime;
            Complexity = complexity;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            Players = new List<Player>(); //Player[MaxPlayers];
        }

        public override string ToString()
        {
            return $"{GetType().Name}: playing time: {PlayingTime}, from {MinPlayers} to {MaxPlayers} player(s)";
        }

        public void Join(Player player)
        {
            if (Players.Count < MaxPlayers)
            {
                Players.Add(player);
                Console.WriteLine($"{player.Name} joined {GetType().Name}");
            }
        }

        public void Start(List<Player> players)
        {
            if (IsFree() && IsRoomForAllPlayersJoining(players))
            {
                foreach (Player player in players)
                {
                    Join(player);
                }
            }

            bool IsFree()
            {
                return Players.Count <= MaxPlayers;
            }

            bool IsRoomForAllPlayersJoining(List<Player> players)
            {
                return players.Count <= MaxPlayers - Players.Count;
            }
        }

        public void Quit(Player player)
        {
            Players.Remove(player);
            player.FinishPlaying();
            Console.WriteLine($"{player.Name} quit playing {GetType().Name}");
        }
    }
}
