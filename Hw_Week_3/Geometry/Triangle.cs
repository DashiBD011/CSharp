using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Triangle:AFigure, IFigure
    {
        private readonly double _A;
        private readonly double _B;
        private readonly double _C;

        public Triangle(double A, double B, double C)
        {
            _A = A;
            _B = B;
            _C = C;
        }

        public double CalcArea()
        {
            double p = CalcPerimeter() / 2; 
            Area = Math.Sqrt(p * (p - _A) * (p - _B) * (p - _C));
            return Area;
        }

        public double CalcPerimeter()
        {
            return _A + _B + _C;
            
        }
    }
}
