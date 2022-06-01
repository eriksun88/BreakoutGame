namespace Breakout_Game
{
    partial class FrmBreakoutgame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPause = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 421);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Red;
            this.lblPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPause.Location = new System.Drawing.Point(597, 421);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(59, 20);
            this.lblPause.TabIndex = 4;
            this.lblPause.Text = "Pause";
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Lime;
            this.lblRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRestart.Location = new System.Drawing.Point(691, 421);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(81, 20);
            this.lblRestart.TabIndex = 5;
            this.lblRestart.Text = "Continue";
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // FrmBreakoutgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblScore);
            this.KeyPreview = true;
            this.Name = "FrmBreakoutgame";
            this.Text = "Break Out Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBreakoutgame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblRestart;
    }
}

