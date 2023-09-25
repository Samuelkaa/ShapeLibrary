using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleSquareTest()
        {
            Circle circle = new Circle(ShapeTypes.Circle, 10);

            double result = circle.Square();
            double expectedResult = 314;

            Assert.AreEqual(expectedResult, result);
        }
    }
}
