using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Basics;

namespace MSTest_test_project
{
    [TestClass]
    public class CustomReplacerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = "o";

            String excepted = "h1la";
            String actual = "";

            actual = obj.CustomReplace(str, character);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void ComprobarCaracteresNumericos()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "3351";
            String character = "3";

            String excepted = "1251";
            String actual = "0151";

            actual = obj.CustomReplace(str, character);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "datos incorrectos en la entrada")]
        public void ComprobarDosCaracteres()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = "33";

            String excepted = "hola";
            String actual = "hola";

            actual = obj.CustomReplace(str, character);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "datos incorrectos en la entrada")]
        public void ComprobarDosCaracteres2()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = "33";

            String excepted = "hola";
            String actual = "hola";

            actual = obj.CustomReplace(str, character);
            Assert.AreEqual(excepted, actual);
        }
    }
}
