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
            Point p3 = new Point(1, 5, '$');
            p3.Draw();
            Point p1 = new Point(2, 2, '@');
            p1.Draw();
            Point p2 = new Point(3, 3, '#');
            p2.Draw();

           
            Console.ReadLine();
        }

     }
}
