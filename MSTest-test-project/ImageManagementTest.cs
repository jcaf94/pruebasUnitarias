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
        public void HorarioImagenLuna()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(5);
            ImageManagement obj = new ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void HorarioImagenSol()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(12);
            ImageManagement obj = new ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("sun.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void LimiteHorarioInferior()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(6);
            ImageManagement obj = new ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void LimiteHorarioSuperior()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(21);
            ImageManagement obj = new ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void HoraNegativa()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(-5);
            ImageManagement obj = new ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }

        [TestMethod]
        public void HoraNull()
        {
            var mock = new Mock<IFecha>();
            mock.Setup(fecha => fecha.getFecha()).Returns(null);
            ImageManagement obj = new ImageManagement(mock.Object);
            string resultado = obj.GetImageForTimeOfDay();

            Assert.AreEqual("moon.jpg", resultado);
            mock.Verify(f => f.getFecha(), Times.Once);
        }
    }
}
