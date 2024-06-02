using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
   public abstract class Shape
    { 
        protected Shape( string name) 
        {
            name = name;
        }
        public string name { get; }
        public virtual string GetName()
        {
            return "Shape:"+name;
        }
        public abstract double CalculateArea();
    }
    
}
