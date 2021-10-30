using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 21);
            Console.SetBufferSize(50, 21);
            
            HorizontalLine hLineUp = new HorizontalLine(0, 50, 0, '+');
            HorizontalLine hLineDown = new HorizontalLine(0, 50, 20, '+');
            VerticalLine vLineLeft = new VerticalLine(0, 0, 20, '+');
            VerticalLine vLineRight = new VerticalLine(49, 0, 20, '+');
            hLineUp.Draw();
            hLineDown.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 5, Directions.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
