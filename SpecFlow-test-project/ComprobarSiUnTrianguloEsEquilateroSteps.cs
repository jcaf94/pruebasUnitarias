using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TriangleDetector;

namespace SpecFlow_test_project
{
    [Binding]
    public class ComprobarSiUnTrianguloEsEquilateroSteps
    {
        TriangleValidator triangle;
        String resultado_actual;

        [Given(@"Un validador de triangulos")]
        public void DadoUnValidadorDeTriangulos()
        {
            triangle = new TriangleValidator();
        }

        [When(@"Creo un triangulo con los lados (.*) (.*) (.*)")]
        public void CuandoCreoUnTrianguloConLosLados(int lado1, int lado2, int lado3)
        {
            resultado_actual = triangle.EsTriangulo(lado1, lado2, lado3);
        }

        [Then(@"El resultado es un triangulo equilatero")]
        public void EntoncesElResultadoEsUnTrianguloEquilatero()
        {
            Assert.AreEqual(TriangleValidator.EQUILATERO, resultado_actual);
        }
    }
}
