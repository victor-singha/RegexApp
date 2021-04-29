using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexApp;
using System;

namespace RegexAppMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_First_Name()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateFirstName("Captain");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test_Last_Name()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateLastName("Singh");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test_Email()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateEmail("singh.captain@gmail.com");
            Assert.AreEqual(true, result);
            //Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_Phone()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateMobile("91 3767563427");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test_Password()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validatePassword("Captain#007");
            Assert.AreEqual(true, result);
        }
    }
}
