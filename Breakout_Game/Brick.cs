using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Breakout_Game
{
    internal class Brick : PictureBox
    {
        public int width = 100;
        int height = 25;

        public Brick (Color color, int left, int right)
        {
            BackColor = color;
            Size = new Size(width, height);
            Location = new Point(left * width, right * height);
        }
    }
}
