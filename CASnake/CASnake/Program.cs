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

            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            int s = numList[3];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);

            List<Point> pointlList = new List<Point>();
            pointlList.Add(p1);
            pointlList.Add(p2);
            pointlList.Add(p3);
            pointlList.Add(p4);

            Console.ReadLine();
        }

     }
}
