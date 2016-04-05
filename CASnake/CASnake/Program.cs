using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1, '$');
            p1.Draw();
            Point p2 = new Point(2, 2, '@');
            p2.Draw();
            Point p3 = new Point(3, 3, '#');
            p3.Draw();
            Point p4 = new Point(4, 4, '&');
            p4.Draw();

            HorisontalLine hLine = new HorisontalLine(5, 50, 5, '+');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(5, 30, 5, '+');
            vLine.Draw();
      
            Console.ReadLine();
        }

     }
}
