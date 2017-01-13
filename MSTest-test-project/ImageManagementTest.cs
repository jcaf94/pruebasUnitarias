using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Mocks.Date;
using Moq;

namespace MSTest_test_project
{
    /// <summary>
    /// Summary description for ImageManagementTest
    /// </summary>
    [TestClass]
    public class ImageManagementTest
    {
        [TestMethod]
        public void TestMethodMoon()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(3);
            MSTest_tests_example.Mocks.Date.ImageManagement obj = new MSTest_tests_example.Mocks.Date.ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void TestMethodSun()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(15);
            MSTest_tests_example.Mocks.Date.ImageManagement obj = new MSTest_tests_example.Mocks.Date.ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("sun.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void TestMethodBorderline()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(6);
            MSTest_tests_example.Mocks.Date.ImageManagement obj = new MSTest_tests_example.Mocks.Date.ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }
    }
}
