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
    public partial class GameScreen : UserControl
    {
        List<Ball> balls = new List<Ball>();
        Player Hero;

        public static int screenWidth;
        public static int screenHeight;

        bool leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        Ball chaseball;
        Random randgen = new Random();

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        public GameScreen()
        {
            InitializeComponent();

            screenWidth = this.Width;
            screenHeight = this.Height;

            InitializeGame();
        }

        public void InitializeGame()
        {
            Hero = new Player();

            int x = randgen.Next(20, this.Width - 50);
            int y = randgen.Next(20, this.Height - 50);

            chaseball = new Ball(x, y, 8, 8);

            for (int i = 0; i < 3; i++)
            {
                x = randgen.Next(20, this.Width - 50);
                y = randgen.Next(20, this.Height - 50);

                Ball b = new Ball(x, y, 8, 8);
                balls.Add(b);
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
                    
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            chaseball.Move();

            foreach (Ball b in balls)
            {
                b.Move();
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(redBrush, chaseball.x, chaseball.y, chaseball.size, chaseball.size);

            e.Graphics.FillRectangle(redBrush, Hero.x, Hero.y, Hero.width, Hero.height);

            foreach (Ball b in balls)
            {
                e.Graphics.FillEllipse(redBrush, b.x, b.y, b.size, b.size);
            }
        }
    }
}
