using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CASnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,40);
            Walls walls = new Walls(70, 35);
            walls.Draw();
            
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake( p, 4, Direction.Right);
            snake.Draw();
            
            FoodKreator foodKreator = new FoodKreator(50, 30, '@');
            Point food = foodKreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.WriteLine("you are loser");
                    Console.ReadLine();
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodKreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(150);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HendleKey(key.Key);
                }
               

            }

        }

    }
}
