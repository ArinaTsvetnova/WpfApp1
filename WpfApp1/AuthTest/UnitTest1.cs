using WpfApp1.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AuthTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthTestSuccess()
        {
            var page = new Page2();
            string pass = "123";
            string log = "123";
            Assert.IsTrue(page.Auth(pass, log));
        }

        [TestMethod]
        public void AuthTestSuccess2()
        {
            var page = new Page2();
            string pass = "456";
            string log = "456";
            Assert.IsTrue(page.Auth(pass, log));
        }

        [TestMethod]
        public void AuthTestSuccess3()
        {
            var page = new Page2();
            string pass = "789";
            string log = "789";
            Assert.IsTrue(page.Auth(pass, log));
        }

        [TestMethod]
        public void AuthTestFail()
        {
            var page = new Page2();
            string pass = "1";
            string log = "1";
            Assert.IsFalse(page.Auth(pass, log));
        }

        [TestMethod]
        public void AuthTestFail2()
        {
            var page = new Page2();
            string pass = "2";
            string log = "";
            Assert.IsFalse(page.Auth(pass, log));
        }

        [TestMethod]
        public void AuthTestFail3()
        {
            var page = new Page2();
            string pass = "";
            string log = "3";
            Assert.IsFalse(page.Auth(pass, log));
        }
    }
}
