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
            HorizontalLine line = new HorizontalLine(2, 20, 3, '*');
            line.Draw();
            VerticalLine vLine = new VerticalLine(2, 4, 10, '*');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
