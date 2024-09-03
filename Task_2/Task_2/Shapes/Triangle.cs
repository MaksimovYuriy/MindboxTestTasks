using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Shapes
{
    public class Triangle : IShape
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }

        public Triangle(double x1, double x2, double x3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
        }

        public double? Area()
        {
            if (X1 >= X2 + X3 || X2 >= X1 + X3 || X3 >= X1 + X2)
            {
                return null;
            }
            double p = (X1 + X2 + X3) / 2;
            return Math.Sqrt(p * (p - X1) * (p - X2) * (p - X3));
        }

        public bool isRightAngled()
        {
            if (X1 == 0 || X2 == 0 || X3 == 0) return false;

            double hypotenuseSquare = Math.Pow(X1, 2) + Math.Pow(X2, 2);
            if (Math.Abs(hypotenuseSquare - Math.Pow(X3, 2)) < double.Epsilon)
            {
                return true;
            }

            hypotenuseSquare = Math.Pow(X2, 2) + Math.Pow(X3, 2);
            if (Math.Abs(hypotenuseSquare - Math.Pow(X1, 2)) < double.Epsilon)
            {
                return true;
            }

            hypotenuseSquare = Math.Pow(X1, 2) + Math.Pow(X3, 2);
            if (Math.Abs(hypotenuseSquare - Math.Pow(X2, 2)) < double.Epsilon)
            {
                return true;
            }

            return false;
        }
    }
}
