using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASnake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorisontalLine uplLine = new HorisontalLine(5, mapWidth - 5, 5, '#');
            HorisontalLine downLine = new HorisontalLine(5, mapWidth - 4, mapHeight - 5, '#');
            VerticalLine leftLine = new VerticalLine(5, mapHeight - 5, 5, '#');
            VerticalLine rightLine = new VerticalLine(5, mapHeight - 5, mapWidth - 5, '#');

            wallList.Add(uplLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
