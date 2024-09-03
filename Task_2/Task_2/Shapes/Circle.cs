using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Shapes
{
    public class Circle : IShape
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double? Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
