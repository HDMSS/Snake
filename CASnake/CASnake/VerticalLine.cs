using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASnake
{
    class VerticalLine
    {
        List<Point> verticalPoints;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            verticalPoints = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, sym);
                verticalPoints.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in verticalPoints)
            {
                p.Draw();
            }
        }
    }
}
