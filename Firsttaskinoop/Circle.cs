using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsttaskinoop
{
    class Circle : Shape
    {
        protected int _radius;
        double pi = 3.14;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public override int CalculateArea()
        {
            Console.WriteLine("area of circle");
            return (int)(pi * _radius * _radius);
        }
        public override int CalculatePerimeter()
        {
            Console.WriteLine("perimeter of circle");
            return (int)(2 * pi * _radius);
        }
        public void IsCircle()
        {
            Console.WriteLine("This is a Circle");
        }
    }
}
