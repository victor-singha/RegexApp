using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexApp;
using System;

namespace RegexAppMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenFirstName_WhenCheck_ShouldReturnTrue()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateFirstName("Captain");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void GivenLastName_WhenCheck_ShouldReturnTrue()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateLastName("Singh");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void GivenEmail_WhenCheck_ShouldReturnTrue()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateEmail("singh.captain@gmail.com");
            Assert.AreEqual(true, result);
            //Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPhone_WhenCheck_ShouldReturnTrue()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validateMobile("91 3767563427");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void GivenPassword_WhenCheck_ShouldReturnTrue()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.validatePassword("Captain#007");
            Assert.AreEqual(true, result);
        }
    }
}
