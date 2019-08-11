using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_Mindox_;
using lab1_Mindox_.Strategy;

namespace UnitTestProject
{
    [TestClass]
    public class CalcFigureTest
    {
        [TestMethod]
        public void AreaCircleRadius2AndRetuned12_566()
        {
            double radius = 2;
            double expected = 12.566;

            Figure circle = new Figure(radius);
            double  area = circle.СalculationArea();

            Assert.AreEqual(expected, area, "Area of the circle not true");
        }

        [TestMethod]
        public void AreaFalseTriangle()
        {
            double a = 3;
            double b = 5;
            double c = 2;
            int expected = -1; 

            Triangle triangle = new Triangle(a, b, c);
            double area = triangle.СalculationArea();

            Assert.AreEqual(expected, area, "The triangle should not be is true");
        }

        [TestMethod]
        public void AreaTrueTriangle()
        {
            double a = 3;
            double b = 5;
            double c = 4;
            double expected = 7.5;

            Figure triangle = new Figure(a, b, c);
            double area = triangle.СalculationArea();

            Assert.AreEqual(expected, area, "The triangle should not be is false");
        }

        [TestMethod]
        public void CheckIsRectangleTriangle()
        {
            double a = 4;
            double b = 5;
            double c = 3;
            bool expected = true;

            Triangle triangle = new Triangle(a, b, c);
            bool checkRectangleTriangle = triangle.IsRectangularTriangle();
           
            
            Assert.AreEqual(expected, checkRectangleTriangle, "The triangle should be rectangular");
        }
    }
}
