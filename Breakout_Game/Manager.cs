using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout_Game
{
    internal class Manager
    {

        Boolean IsPaused, Start;
        int speed = 0;

        public void Init()
        {
            FrmBreakoutgame game = new FrmBreakoutgame();
            game.Show();
        }
    }
}
