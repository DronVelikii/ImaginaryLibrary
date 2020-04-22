using System;
using ImaginaryLibrary.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImaginaryLibrary.Tests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestCircleAreaCheck4()
        {
            AbstractShape circle = new Circle(4);

            Assert.AreEqual(Math.Round(circle.GetArea(), 2), 50.27);
        }

        [TestMethod]
        public void TestCircleAreaZero()
        {
            AbstractShape circle = new Circle(0);

            Assert.AreEqual(Math.Round(circle.GetArea(), 2), 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "R cannot be less than zero")]
        public void TestCircleAreaException()
        {
            AbstractShape circle = new Circle(-1);

            var area = circle.GetArea();
        }
    }
}