using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsttaskinoop
{
    class Rectangle : Shape
    {
        protected int _height;
        protected int _width;

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public override int CalculateArea()
        {
            Console.WriteLine("area of rectangle");
            return _height * _width;
        }
        public override int CalculatePerimeter()
        {
            Console.WriteLine("perimeter of circle");
            return 2 * (_height + _width);
        }
        public void IsRectangle()
        {
            Console.WriteLine("This ia a rectangle");
        }

    }
}
