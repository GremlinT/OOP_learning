using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_OOP
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        
        public Point()
        {
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Directions dir)
        {
            if (dir == Directions.UP)
            {
                y = y + offset;
            }
            if (dir == Directions.DOWN)
            {
                y = y - offset;
            }
            if (dir == Directions.RIGHT)
            {
                x = x + offset;
            }
            if (dir == Directions.LEFT)
            {
                x = x - offset;
            }
        }

    }
}
