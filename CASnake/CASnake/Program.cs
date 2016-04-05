﻿using System;
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
            Console.SetBufferSize(100,50);
            HorisontalLine hupLine = new HorisontalLine(5, 70, 5, '#');
            HorisontalLine hdownLine = new HorisontalLine(5, 70, 35, '#');
            VerticalLine vleftLine = new VerticalLine(5, 35, 5, '#');
            VerticalLine vrightLine = new VerticalLine(5, 35, 69, '#');
            hdownLine.Draw();
            hupLine.Draw();
            vrightLine.Draw();
            vleftLine.Draw();

            Point p = new Point(15, 15, '*');
            p.Draw();
           
      
            Console.ReadLine();
        }

     }
}
