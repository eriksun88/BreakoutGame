using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout_Game
{
    public class Manager
    {
        public Boolean IsPaused, Start;
        public int Speed;
        public int Score = 0;
        FrmBreakoutgame Game;

        public Manager()
        {
            Game = new FrmBreakoutgame(this);
        }

        public void Init(int speed)
        {
            Start = true;
            Speed = speed;
            Score = 0;
            Game.Show();
        }
    }
}
