using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Square : AFigure, IFigure
    {
        private readonly double _side;

        public Square(double side) => _side = side;

        public double CalcArea()
        {
            Area = _side * _side;
            return Area;
        }

        public double CalcPerimeter()
        {
            Perimeter = _side * 4;
            return Perimeter;
        }
    }
}