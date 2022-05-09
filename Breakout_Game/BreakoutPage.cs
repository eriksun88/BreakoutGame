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
        int width = 2000;
        int height = 500;
        Manager manager;

        private Random rnd = new Random();
        public FrmBreakoutgame(Manager manager)
        {
            this.manager = manager;
            CreateBricks();
            CreateBall();           
            InitializeComponent();
            lblScore.Text = "Score: " + this.manager.Score;
        }

        private void CreateBricks()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 8; x++)
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

        private void CreatePaddle()
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.manager.IsPaused = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.manager.IsPaused = false;
        }
    }
}
