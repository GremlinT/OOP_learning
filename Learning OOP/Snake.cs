using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_OOP
{
    class Snake: Figure
    {
        Directions dir;
        
        public Snake(Point tail, int lenght, Directions _dir)
        {
            dir = _dir;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

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
            Point nextPoint = new Point (head);
            nextPoint.Move(1, dir);
            return nextPoint;
        }
         
        public void HandlKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                dir = Directions.LEFT;
            else if (key == ConsoleKey.RightArrow)
                dir = Directions.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                dir = Directions.UP;
            else if (key == ConsoleKey.DownArrow)
                dir = Directions.DOWN;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Change(head.sym);
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else 
                return false;
        }

        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }


    }
}
