using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Basics;

namespace MSTest_test_project
{
    [TestClass]
    public class CustomReplacerTest
    {
        [TestMethod]
        public void CustomReplacerCorrecto()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = "o";

            String expected = "h1la";

            String actual = obj.CustomReplace(str, character);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomReplacerNoCharInString()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = "e";

            String expected = "hola";

            String actual = obj.CustomReplace(str, character);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "datos incorrectos en la entrada")]
        public void CustomReplacerCharTooLong()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = "ol";

            String actual = obj.CustomReplace(str, character);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "datos incorrectos en la entrada")]
        public void CustomReplacerStringIsNull()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = null;
            String character = "o";

            String actual = obj.CustomReplace(str, character);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "datos incorrectos en la entrada")]
        public void CustomReplacerCharIsNull()
        {
            CustomReplacer obj = new CustomReplacer();
            String str = "hola";
            String character = null;

            String actual = obj.CustomReplace(str, character);
        }
    }
}
