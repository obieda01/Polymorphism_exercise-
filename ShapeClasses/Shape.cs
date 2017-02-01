﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{

    public class Shape

    {

        protected int m_xpos;
        protected int m_ypos;

        public Shape()
        {
        }

        public Shape(int x, int y)
        {
            m_xpos = x;
            m_ypos = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a SHAPE at {0},{1}", m_xpos, m_ypos);        
        }
    }
}
