using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class Circle : Shape
    {
        public Circle(string name) : base(name)
        { 
            
        }  public double side1;
        public  double side2;
        public Circle(string name,double side1,double side2) : base(name)
        {
            

        } public override double CalculateArea()
        {
            double area=side1*side2;
            return area;
        }

       
    }
}
