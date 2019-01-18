using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsttaskinoop
{
    abstract class Shape
    {
        protected int _area;
        protected string _color;
        protected int _perimeter;

        
        public abstract int CalculateArea();
        public abstract int CalculatePerimeter();
        
    }
}
