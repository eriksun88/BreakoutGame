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
        private Point MouseDownLocation;

        private Random rnd = new Random();
        public FrmBreakoutgame(Manager manager, int bricksPerRow, int bricksPerCol)
        {
            this.manager = manager;
            CreateBricks(bricksPerRow, bricksPerCol);
            CreateBall();
            CreatePaddle();
            InitializeComponent();
            Size = new Size(width, height);
            lblScore.Text = "Score: " + this.manager.Score;
        }

        private void CreateBricks(int bricksPerRow, int bricksPerCol)
        {
            for (int y = 0; y < bricksPerCol; y++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                for (int x = 0; x < bricksPerRow; x++)
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
            paddle.MouseDown += Paddle_MouseDown;
            paddle.MouseMove += Paddle_MouseMove;
            this.Controls.Add(paddle);
        }

        private void Paddle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Paddle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int leftPos = e.X + paddle.Left - MouseDownLocation.X;
                if (leftPos < 0)
                {
                    leftPos = 0;
                }
                if (leftPos + paddle.Width > width)
                {
                    leftPos = width - paddle.Width;
                }                
                paddle.Left = leftPos;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && paddle.Left > 0)
            {
                paddle.goLeft = true;
            }
            if (e.KeyCode == Keys.Right && paddle.Left + paddle.Width < width)
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
            if (manager.Start && !manager.IsPaused)
            {
                paddle.Moving(manager.Speed, width);
                ball.Moving();

                if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
                {
                    ball.ballx = -ball.ballx;
                }

                if (ball.Top < 0 || ball.Bounds.IntersectsWith(paddle.Bounds))
                {
                    ball.bally = -ball.bally;
                }

                if (ball.Top + ball.Height > ClientSize.Height)
                {
                    gameOver();
                    MessageBox.Show("Oops! You Failed");
                }
                foreach (Control x in this.Controls)
                {
                    if (x is Brick)
                    {
                        if (ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            ball.bally = -ball.bally;
                            manager.AddScore();
                            lblScore.Text = "Score: " + manager.Score;
                        }
                    }
                }
                if (manager.CheckWin())
                {
                    gameOver();
                    MessageBox.Show("You Win");
                }
            }            
        }
        public void gameOver()
        {
            timer1.Stop();
            manager.Start = false;
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            manager.IsPaused = true;
            timer1.Stop();
        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            manager.IsPaused = false;
            timer1.Start();
        }
    }
}
