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
        public int ScorePerBrick = 10;
        int bricksPerRow = 8;
        int bricksPerCol = 5;
        FrmBreakoutgame Game;
        System.Media.SoundPlayer SoundPlayer;

        public Manager()
        {
            SetUpSoundPlayer();
        }

        public void Init(int speed)
        {
            Game = new FrmBreakoutgame(this, bricksPerRow, bricksPerCol);
            Start = true;
            Speed = speed;
            Score = 0;
            Game.Show();
            PlaySoundLoop();
        }

        private void SetUpSoundPlayer()
        {
            SoundPlayer = new System.Media.SoundPlayer();
            SoundPlayer.SoundLocation = @"..\..\bgmusic.wav";
        }

        public void AddScore()
        {
            Score += ScorePerBrick;
        }

        public void PlaySoundLoop()
        {
            SoundPlayer.PlayLooping();
        }

        public void StopSound()
        {
            SoundPlayer.Stop();
        }

        public bool CheckWin()
        {
            if (Score >= bricksPerRow * bricksPerCol * 10)
            {
                return true;                
            }
            return false;
        }

        public void ShowResult(string msg)
        {
            StopSound();
            if (Game.ShowMessageBox(msg))
            {
                Game.Close();
                Init(Speed);
            }
            else
            {
                Game.Close();
            }
        }
    }
}
