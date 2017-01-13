using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Private;
using System.Reflection;

namespace MSTest_test_project
{
    /// <summary>
    /// Summary description for LogOnInfoTest
    /// </summary>
    [TestClass]
    
    public class LogOnInfoTest
    {
        [TestMethod]
        public void ConstructorTipoIncorrecto()
        {
            String excepted = "No se encontró un constructor en el tipo 'MSTest_tests_example.Private.LogonInfo'.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), 3, '5');
            }

            catch (System.MissingMethodException ex)
            {
                Assert.AreEqual(excepted, ex.Message.ToString());
            }

        }

        [TestMethod]
        public void ConstructorParametrosNull()
        {
            String excepted = "No se encontró un constructor en el tipo 'MSTest_tests_example.Private.LogonInfo'.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), null, null);
            }

            catch (System.MissingMethodException ex)
            {
                Assert.AreEqual(excepted, ex.Message.ToString());
            }

        }

        [TestMethod]
        public void ConstructorPasswordCorrecta()
        {
            String password_excepted = "Sa12+?";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "Sa12+?");

                string password = privateObject.GetProperty("Password").ToString();

                Assert.AreEqual(password_excepted, password);
            }

            catch (TargetInvocationException ex)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void PasswordDemasiadoSimple()
        {
            String excepted = "Password does not meet the complexity requirements.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "1234");
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void PasswordTipoIncorrecto()
        {
            String excepted = "No se encontró un constructor en el tipo 'MSTest_tests_example.Private.LogonInfo'.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", '5');
            }

            catch (System.MissingMethodException ex)
            {
                Assert.AreEqual(excepted, ex.Message.ToString());
            }

        }

        [TestMethod]
        public void PasswordNull()
        {
            String excepted = "Password may not be null or blank.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", null);
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void PasswordEmpty()
        {
            String excepted = "Password may not be null or blank.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", null);
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void ConstructorUsuarioIDCorrecto()
        {
            String idUsuario_excepted = "1";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "Sa12+?");

                string id_usuario = privateObject.GetProperty("UserId").ToString();

                Assert.AreEqual(idUsuario_excepted, id_usuario);
            }

            catch (TargetInvocationException ex)
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void UsuarioIDTipoIncorrecto()
        {
            String excepted = "No se encontró un constructor en el tipo 'MSTest_tests_example.Private.LogonInfo'.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), 1, "5");
            }

            catch (System.MissingMethodException ex)
            {
                Assert.AreEqual(excepted, ex.Message.ToString());
            }

        }

        [TestMethod]
        public void UsuarioIDEmpty()
        {
            String excepted = "Parameter userId may not be null or blank.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "", "1234");
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void UsuarioIDNull()
        {
            String excepted = "Parameter userId may not be null or blank.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), null, "1234");
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }
    }
}
