using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    public class Square : Shape
    {
        public Square()
        {
        }

        public Square(int x, int y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a SQUARE at {0},{1}", m_xpos, m_ypos);
        }
    }
}
