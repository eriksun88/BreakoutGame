using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public partial class FrmBreakoutgame : Form
    {
        int height = 1000;
        int width = 500;
        bool goRight;
        bool goLeft;
        int speed = 10;

        int ballx = 5;
        int bally = 5;

        int score = 0;

        private Random rnd = new Random();
        public FrmBreakoutgame()
        {
            Size = new Size(height, width);
            CreateBricks();
            CreateBall();
            InitializeComponent();
        }

        private void CreateBricks()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    Brick brick = new Brick(randomColor, x, y);
                    this.Controls.Add(brick);
                }
            }
        }

        private void CreateBall()
        {
            Ball ball = new Ball();
            this.Controls.Add(ball);
        }
    }
}
