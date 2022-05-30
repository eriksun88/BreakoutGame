using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Breakout_Game
{
    internal class Paddle : PictureBox
    {
        int width = 175;
        int height = 15;
        int initX = 12;
        int initY = 381;
        public bool goRight = false;
        public bool goLeft = false;
        public Paddle()
        {
            Size = new Size(width, height);
            Location = new Point(initX, initY);
            BackColor = Color.White;
        }

        public void Moving(int speed, int maxWidth)
        {
            if (goLeft) { Left -= speed * 10; }
            if (goRight) { Left += speed * 10; }
            if (Left < 1)
            {
                goLeft = false;
            }
            else if (Left + Width > maxWidth)
            {
                goRight = false;
            }
        }
    }
}
