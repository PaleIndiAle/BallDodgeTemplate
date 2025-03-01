using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallDodgeTemplate
{
    internal class Ball
    {
        public int x, y;
        public int size = 10;
        public int xspeed, yspeed;

        public Ball(int _x, int _y, int _xspeed, int _yspeed)
        {
            x = _x;
            y = _y;
            size = _xspeed;
            xspeed = _yspeed;
            yspeed = _yspeed;
        }

        public void Move()
        {
            x += xspeed;
            y += yspeed;

            if (x < 0 || x > 600)
            {
                xspeed = -xspeed;
            }

            if (y < 0 || y > 500)
            {
                yspeed = -yspeed;
            }
        }
    }
}
