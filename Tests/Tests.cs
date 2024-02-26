using Xunit;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaCalculationTest()
        {
            Circle circle = new Circle(5);
            double expectedArea = 78.54;

            double calculatedArea = circle.CalculateArea();

            Assert.Equal(expectedArea, calculatedArea, 2);
        }

        [Fact]
        public void TriangleAreaCalculationTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            double calculatedArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, calculatedArea);
        }

        [Fact]
        public void RightAngledTriangleTest()
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(6, 8, 10);
            Triangle triangle3 = new Triangle(1, 2, 3);

            Assert.True(triangle1.IsRightAngled());
            Assert.True(triangle2.IsRightAngled());
            Assert.False(triangle3.IsRightAngled());
        }
    }
}
