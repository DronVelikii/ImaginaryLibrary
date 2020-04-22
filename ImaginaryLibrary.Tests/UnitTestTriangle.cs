using System;
using ImaginaryLibrary.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImaginaryLibrary.Tests
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestTriangle8_12_16()
        {
            AbstractShape triangle = new Triangle(8, 12, 16);

            Assert.AreEqual(Math.Round(triangle.GetArea(), 2), 46, 47);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "a,b,c cannot be less than zero")]
        public void TestTriangleException()
        {
            AbstractShape triangle = new Triangle(-1, 2, 4);

            var area = triangle.GetArea();
        }
    }
}