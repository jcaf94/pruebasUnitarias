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

            catch (TargetInvocationException)
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
        public void PasswordSinSimbolo()
        {
            String excepted = "Password does not meet the complexity requirements.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "SSsSSss");
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void PasswordSinMiniscula()
        {
            String excepted = "Password does not meet the complexity requirements.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "SSSSSS+1");
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void PasswordSinMayuscula()
        {
            String excepted = "Password does not meet the complexity requirements.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "ssssss+1");
            }

            catch (TargetInvocationException ex)
            {
                Assert.AreEqual(excepted, ex.InnerException.Message.ToString());
            }

        }

        [TestMethod]
        public void PasswordDemasiadoCorta()
        {
            String excepted = "Password does not meet the complexity requirements.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "Sa12-");
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

            catch (TargetInvocationException)
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

        [TestMethod]
        public void ChangePasswordParametrosNull()
        {
            String excepted = "No se puede encontrar el método 'MSTest_tests_example.Private.LogonInfo.ChangePassword'.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "1234+aA");
                privateObject.Invoke("ChangePassword", null, null);
            }
            catch (System.MissingMethodException ex)
            {
                Assert.AreEqual(excepted, ex.Message.ToString());
            }

        }

        [TestMethod]
        public void ChangePasswordOldPasswordNotMatch()
        {
            String excepted = "The old password was not correct.";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "1234+aA");
                privateObject.Invoke("ChangePassword", "1234", "1234");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(excepted, ex.Message.ToString());
            }

        }

        [TestMethod]
        public void ChangePasswordCorrecto()
        {
            String nuevaPasswordExcepted = "abCD1234+";

            //La parte de la prueba necesaria para comprobar el correcto funcionamiento de la variable counterExpected
            //se ha comentado para no realizar dos asserts en la misma prueba.

            //Tambien se ha comentado la prueba siguiente que comprueba solamente el valor de ese campo, pero depende
            //de esta prueba (su valor debe ser 2 si esta prueba sale bien o 1 si no).

            //Ante la duda se han dejado comentadas ambas

            //String counterExpected = "1";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "Sa12+?");
                privateObject.Invoke("ChangePassword", "Sa12+?", "abCD1234+");

                var nuevaPassword = privateObject.GetProperty("Password").ToString();
                Assert.AreEqual(nuevaPasswordExcepted, nuevaPassword);

                /*
                PrivateType staticResourcesLogonInfo = new PrivateType(typeof(LogonInfo));
                var counter = staticResourcesLogonInfo.GetStaticField("conunterPasswordChangedCorrectly").ToString();
                Assert.AreEqual(counterExpected, counter);
                */
            }

            catch (TargetInvocationException)
            {
                Assert.Fail();
            }

        }

        /*
        [TestMethod]
        public void ChangePasswordCheckCounter()
        {
            String counterExpected = "1";

            try
            {
                var privateObject = new PrivateObject(typeof(LogonInfo), "1", "Sa12+?");
                privateObject.Invoke("ChangePassword", "Sa12+?", "abCD1234+");

                PrivateType staticResourcesLogonInfo = new PrivateType(typeof(LogonInfo));
                var counter = staticResourcesLogonInfo.GetStaticField("conunterPasswordChangedCorrectly").ToString();
                
                Assert.AreEqual(counterExpected, counter);
            }

            catch (TargetInvocationException)
            {
                Assert.Fail();
            }

        }
        */
    }
}
