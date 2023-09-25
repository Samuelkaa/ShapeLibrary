using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleSquareTest()
        {
            Triangle triangle = new Triangle(ShapeTypes.Triangle, 5, 10, 14);

            double result = triangle.Square();
            double expectedResult = 17.6;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RectangleTest()
        {
            Triangle triangle = new Triangle(ShapeTypes.Triangle, 3, 4, 5);

            bool isRect = triangle.isRectangular();

            Assert.IsTrue(isRect);
        }
    }
}