using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsttaskinoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square(5);
            int sq_area = sqr.CalculateArea();
            Console.WriteLine(sq_area);
            int sqr_peri = sqr.CalculatePerimeter();
            Console.WriteLine(sqr_peri);
            sqr.IsSquare();

            Rectangle rec = new Rectangle(2, 3);
            int rec_area = rec.CalculateArea();
            Console.WriteLine(rec_area);
            int rec_peri = rec.CalculatePerimeter();
            Console.WriteLine(rec_peri);
            rec.IsRectangle();

            Shape cir = new Circle(2);
            int cir_area = cir.CalculateArea();
            Console.WriteLine(cir_area);
            int cir_peri = cir.CalculatePerimeter();
            Console.WriteLine(cir_peri);
            //cir.IsCircle();
        }
    }

   
}
