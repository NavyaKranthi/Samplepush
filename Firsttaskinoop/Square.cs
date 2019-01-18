using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsttaskinoop
{
    class Square : Shape
    {
        protected int _side;

        public Square(int side)
        {
            _side = side;
        }

        public override int CalculateArea()
        {
            Console.WriteLine("area of square");
            return _side * _side;
        }
        public override int CalculatePerimeter()
        {
            Console.WriteLine("perimeter of square");
            return 4 * _side;
        }
        public void IsSquare()
        {
            Console.WriteLine("This is a square");
        }
    }
}
