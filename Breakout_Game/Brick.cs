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
        int width = 90;
        int height = 20;
        int paddingX = 10;
        int paddingY = 10;

        public Brick (Color color, int left, int right)
        {
            BackColor = color;
            Size = new Size(width, height);
            Location = new Point(paddingX + left * (width + paddingX), paddingY + right * (height + paddingY));
        }
    }
}
