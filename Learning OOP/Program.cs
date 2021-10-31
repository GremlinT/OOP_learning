using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Learning_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls wall = new Walls(50, 20);
            wall.Draw();
            
            Point p = new Point(2,2,'*');
            Snake snake = new Snake(p, 2, Directions.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(50, 20, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
                
                
            }
            

            Console.ReadLine();
        }
    }
}
