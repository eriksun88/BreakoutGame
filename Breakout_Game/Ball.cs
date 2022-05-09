using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Breakout_Game
{
    internal class Ball : PictureBox
    {
        int width = 10;
        int height = 10;
        int initX = 0;
        int initY = 300;
        public int ballx = 5;
        public int bally = 5;
        
        public Ball()
        {
            Size = new Size(width, height);
            Location = new Point(initX, initY);
            Image = Image.FromFile(@"..\..\Pink.png");
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
