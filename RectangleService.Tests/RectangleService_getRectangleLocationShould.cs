using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RectangleService;
using System.Drawing;

namespace RectangleService.Tests
{
    [TestClass]
    public class RectangleService_getRectangleLocationShould
    {
        [TestMethod]
        public void getRectangleLocation_NormalInput_Result()
        {
            double centerX = 0, centerY = 0, width = 200, height = 100;
            var rectangleService = new RectangleService();
            Point result = rectangleService.getRectangleLocation(centerX, centerY, width, height);

            Assert.AreEqual(-100, result.X);
            Assert.AreEqual(-50, result.Y);
        }


        [TestMethod]
        public void getRectangleLocation_ZeroWidth_Result()
        {
            double centerX = 0, centerY = 0, width = 0, height = 100;
            var rectangleService = new RectangleService();
            Point result = rectangleService.getRectangleLocation(centerX, centerY, width, height);

            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
        }

        [TestMethod]
        public void getRectangleLocation_ZeroHeight_Result()
        {
            double centerX = 0, centerY = 0, width = 200, height = 0;
            var rectangleService = new RectangleService();
            Point result = rectangleService.getRectangleLocation(centerX, centerY, width, height);

            Assert.AreEqual(0, result.X);
            Assert.AreEqual(0, result.Y);
        }
    }
}
