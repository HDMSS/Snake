using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASnake
{
    class HorisontalLine
    {
        List<Point> horisontalPoints;

        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
           horisontalPoints = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                horisontalPoints.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in horisontalPoints)
            {
                p.Draw();
            }
        }
    }
}
