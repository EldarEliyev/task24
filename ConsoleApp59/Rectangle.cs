using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class Rectangle : Shape
    {
        public Rectangle(string name) : base(name)
        {

        }
        private double side1;
        private double side2;
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double CalculateArea()
        {
            double area = side1 * side2;
            return area;
        }

    }
}