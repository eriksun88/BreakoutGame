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
        Manager manager;
        Paddle paddle;
        Ball ball;
        int height = 500;
        int width = 830;
        private Random rnd = new Random();
        public FrmBreakoutgame(Manager manager)
        {
            this.manager = manager;
            CreateBricks();
            CreateBall();
            CreatePaddle();
            InitializeComponent();
            Size = new Size(width, height);
            lblScore.Text = "Score: " + this.manager.Score;
        }

        private void CreateBricks()
        {
            for (int y = 0; y < 5; y++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                for (int x = 0; x < 8; x++)
                {                    
                    Brick brick = new Brick(randomColor, x, y);
                    this.Controls.Add(brick);
                }
            }
        }

        private void CreateBall()
        {
            ball = new Ball();
            this.Controls.Add(ball);
        }

        private void CreatePaddle()
        {
            paddle = new Paddle();
            this.Controls.Add(paddle);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.manager.IsPaused = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.manager.IsPaused = false;
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && paddle.Left > 0)
            {
                paddle.goLeft = true;
            }
            if (e.KeyCode == Keys.Right && paddle.Left + paddle.Width < 826)
            {
                paddle.goRight = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                paddle.goRight = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += ball.ballx;
            ball.Top += ball.bally;

            //label1.Text = "Score: " + score;

            if (paddle.goLeft) { paddle.Left -= manager.Speed; } // move left
            if (paddle.goRight) { paddle.Left += manager.Speed; } // move right

            if (paddle.Left < 1)
            {
                paddle.goLeft = false; // stop the car from going off screen
            }
            else if (paddle.Left + paddle.Width > 920)
            {
                paddle.goRight = false;
            }
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ball.ballx = -ball.ballx; // this will bounce the object from the left or right border
            }

            if (ball.Top < 0 || ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                ball.bally = -ball.bally; // this will bounce the object from top and bottom border
            }

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameOver();
            }
            foreach (Control x in this.Controls)
            {
                if (x is Brick)
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ball.bally = -ball.bally;
                        manager.Score = manager.Score + 10;
                    }
                }
            }

            if (manager.Score > 34)
            {
                gameOver();
                MessageBox.Show("You Win");
            }
        }
        private void gameOver()
        {
            timer1.Stop();
        }
    }
}
