using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(int x, int y) : base(x, y)
        {

        }

        public override void Draw()

        {
            Console.WriteLine("Drawing a CIRCLE at {0},{1}", m_xpos, m_ypos);
        }

        public void FillCircle()
        {
            Console.WriteLine("Filling CIRCLE at {0},{1}", m_xpos, m_ypos);
        }
    }
}
