using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muBoard_Game_Pub
{
    public class Player
    {
        private bool isPlaying { get; set; }
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
        }

        public void StartPlaying()
        {
            isPlaying = true;
        }

        public void FinishPlaying()
        {
            isPlaying = false;
        }
    }
}
