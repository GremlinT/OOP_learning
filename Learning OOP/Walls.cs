using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_OOP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int wihgt, int height)
        {
            wallList = new List<Figure>();
            
            HorizontalLine hLineUp = new HorizontalLine(0, wihgt, 0, '+');
            HorizontalLine hLineDown = new HorizontalLine(0, wihgt, height, '+');
            VerticalLine vLineLeft = new VerticalLine(0, 0, height, '+');
            VerticalLine vLineRight = new VerticalLine(wihgt, 0, height, '+');
            wallList.Add(hLineUp);
            wallList.Add(hLineDown);
            wallList.Add(vLineLeft);
            wallList.Add(vLineRight);
        }

        internal bool IsHit(Figure f)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(f))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
