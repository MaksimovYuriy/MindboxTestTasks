using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;
using Task_2.Shapes;

namespace UnitTests
{
    public class Tests
    {
        [Fact]
        public void Area_1()
        {
            //Arrange
            Circle circle = new Circle(radius: 10);
            //Act
            double? areaResult = ShapeUtils.Area(circle);
            double? needResult = Math.PI * 10 * 10;
            //Assert
            Assert.Equal(needResult, areaResult);
        }

        [Fact]
        public void Area_2()
        {
            //Arrange
            Triangle triangle = new Triangle(x1: 3, x2: 4, x3: 5);
            //Act
            double? areaResult = ShapeUtils.Area(triangle);

            double p = (3 + 4 + 5) / 2;
            double? needResult = Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5));
            //Assert
            Assert.Equal(needResult, areaResult);
        }

        [Fact]
        public void Area_3()
        {
            //Arrange
            Triangle circle = new Triangle(x1: 10, x2: 2, x3: 4);
            //Act
            double? areaResult = ShapeUtils.Area(circle);
            //Assert
            Assert.Null(areaResult);
        }

        [Fact]
        public void RightAngledTriangle_1()
        {
            //Arrange
            Triangle triangle = new Triangle(x1: 3, x2: 4, x3: 5);
            //Act
            bool result = ShapeUtils.isRightAngledTriangle(triangle);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void RightAngledTriangle_2()
        {
            //Arrange
            Triangle triangle = new Triangle(x1: 5, x2: 4, x3: 3);
            //Act
            bool result = ShapeUtils.isRightAngledTriangle(triangle);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void RightAngledTriangle_3()
        {
            //Arrange
            Triangle triangle = new Triangle(x1: 10, x2: 3, x3: 8);
            //Act
            bool result = ShapeUtils.isRightAngledTriangle(triangle);
            //Assert
            Assert.False(result);
        }
    }
}
