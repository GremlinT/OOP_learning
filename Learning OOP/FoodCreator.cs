using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_OOP
{
    class FoodCreator
    {
        int wight;
        int height;
        char sym;

        Random random = new Random();

        public FoodCreator (int _wight, int _height, char _sym)
        {
            wight = _wight;
            height = _height;
            sym = _sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, wight - 2);
            int y = random.Next(2, height - 2);
            return new Point(x, y, sym);
        }
    }
}
