﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASnake
{
    class FoodKreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();
        public FoodKreator(int mapWidht, int mapHeight, char sym)
        { 
            this.mapHeight = mapHeight;
            this.mapWidht = mapWidht;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(5, mapWidht - 2);
            int y = random.Next(5, mapHeight - 2);
            return new Point(x, y, sym);
            
        }
    }
}
