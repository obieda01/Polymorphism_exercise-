using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeClasses;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape(100, 100);
            shapes[1] = new Square(200, 200);
            shapes[2] = new Circle(300, 300);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }


            Console.ReadKey();


            //Shape s = new Circle(100, 100);

            //s.Draw();

            //s.FillCircle();

            //Circle c;

            //c = (Circle)s;

            //c.FillCircle();

            //Console.ReadKey();


            //Shape s = new Circle(100, 100);
            //((Circle)s).FillCircle();

            //Console.ReadKey();


        }
    }
}
