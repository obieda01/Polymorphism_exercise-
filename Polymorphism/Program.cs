using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeClasses;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape(100, 100);
            sh.Draw();

            Square sq = new Square(200, 200);
            sq.Draw();

            Circle ci = new Circle(300, 300);
            ci.Draw();

            Console.ReadKey();
        }
    }
}
