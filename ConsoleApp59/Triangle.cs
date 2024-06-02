using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class Triangle : Shape
    {
        public Triangle(string name) : base(name)
        { 
            
        } public double side;
        public double height;
        public Triangle (string name,double side,double height): base(name)
        {
            this.side = side;
            this.height = height;
        }

       

        public override double CalculateArea()
        {
            double area = (side * height); 
            return area;
        }

       
    }
}
