using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodgeTemplate
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            GameOverall.ChangeScreen(this, new GameScreen());
            GameScreen.points = 0;
            GameScreen.lives = 5;
            GameScreen.diffculty = 2;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            GameOverall.ChangeScreen(this, new GameScreen());
            GameScreen.points = 0;
            GameScreen.lives = 4;
            GameScreen.diffculty = 4;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            GameOverall.ChangeScreen(this, new GameScreen());
            GameScreen.points = 0;
            GameScreen.lives = 3;
            GameScreen.diffculty = 8;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
