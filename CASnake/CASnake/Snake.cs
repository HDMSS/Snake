using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CASnake
{
    class Snake : Figure
    {
        private Direction direction;
        
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
            
        }

        //public SnakeBody(Point tail, Point head)
        //{
        //    SnakeBody = 
        //}

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        //internal void Body()
        //{
            

        //}

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
        
        public void HendleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && direction != Direction.Right) direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow && direction != Direction.Left) direction = Direction.Right;
            else if (key == ConsoleKey.DownArrow && direction != Direction.Up) direction = Direction.Down;
            else if (key == ConsoleKey.UpArrow && direction != Direction.Down) direction = Direction.Up;
       
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
