using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaculatDistnce
{
    class Point
    {
        private int x;
        private int y;

        public double distance;
        public Point()
        {
            x = -1;
            y = -1;
        }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public double distanceTo(Point p)
        {
            int xdiff = x - p.x;
            int ydiff = y - p.y;
            return distance = Math.Sqrt(xdiff * xdiff + ydiff * ydiff);
        }
    }
}
