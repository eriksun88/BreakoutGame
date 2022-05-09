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
    public partial class WelcomePage : Form
    {
        Manager manager;
        public WelcomePage()
        {
            manager = new Manager();
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            manager.Init(10);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            manager.Init(20);
        }
    }
}
