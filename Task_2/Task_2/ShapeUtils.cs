using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Shapes;

namespace Task_2
{
    public static class ShapeUtils
    {
        public static double? Area(IShape shape)
        {

            if(shape is Circle circle)
            {
                return circle.Area();
            }

            if(shape is Triangle trianle)
            {
                return trianle.Area();
            }

            return null;
        }

        public static bool isRightAngledTriangle(IShape shape)
        {
            if (shape is Triangle triangle)
            {
                return triangle.isRightAngled();
            }
            return false;
        }
    }
}
