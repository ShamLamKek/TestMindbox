using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMindbox.Models;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CalculateAreaTestSuccess()
        {
            double  sideone = 3,
                    sidetwo = 4,
                    sidethree = 5,
                    expected = 6;

            Triangle triangle = new Triangle(sideone,sidetwo,sidethree);
            double actual =triangle.CalculateArea();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CalculateAreaTestFail()
        {
            double sideone = 3,
                    sidetwo = 4,
                    sidethree = 5,
                    expected = 10;

            Triangle triangle = new Triangle(sideone, sidetwo, sidethree);
            double actual = triangle.CalculateArea();

            Assert.AreNotEqual(expected, actual);

        }
        [TestMethod]
        public void CheckTriangleTestSuccess()
        {
            double sideone = 3,
                   sidetwo = 4,
                   sidethree = 5;
            bool expected = true;

            Triangle triangle = new Triangle(sideone, sidetwo, sidethree);
            bool actual = triangle.Check();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckTriangleTestFail()
        {
            double sideone = 3,
                   sidetwo = 4,
                   sidethree = 5;
            bool expected = false;

            Triangle triangle = new Triangle(sideone, sidetwo, sidethree);
            bool actual = triangle.Check();

            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateAreaSuccess()
        {
            double sideone = 3.0,
                   expected = 28.26;

            Circle circle = new Circle(sideone);
            double actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void CalculateAreaFail()
        {
            double sideone = 3,
                   expected = 30;

            Circle circle = new Circle(sideone);
            double actual = circle.CalculateArea();

            Assert.AreNotEqual(expected, actual, 0.001);
        }
    }
}
