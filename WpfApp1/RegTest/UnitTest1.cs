using WpfApp1.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RegTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RegTestSuccess()
        {
            var page = new Page4();
            string N = "10";
            string E = "10";
            string P = "10";
            Assert.IsTrue(page.Reg(N, E, P));
        }

        [TestMethod]
        public void RegTestSuccess2()
        {
            var page = new Page4();
            string N = "5";
            string E = "6";
            string P = "7";
            Assert.IsTrue(page.Reg(N, E, P));
        }

        [TestMethod]
        public void RegTestSuccess3()
        {
            var page = new Page4();
            string N = "1";
            string E = "2";
            string P = "3";
            Assert.IsTrue(page.Reg(N, E, P));
        }

        [TestMethod]
        public void RegTestFail()
        {
            var page = new Page4();
            string N = "";
            string E = "";
            string P = "";
            Assert.IsFalse(page.Reg(N, E, P));
        }

        [TestMethod]
        public void RegTestFail2()
        {
            var page = new Page4();
            string N = " ";
            string E = "0";
            string P = "";
            Assert.IsFalse(page.Reg(N, E, P));
        }

        [TestMethod]
        public void RegTestFail3()
        {
            var page = new Page4();
            string N = " ";
            string E = " ";
            string P = " ";
            Assert.IsFalse(page.Reg(N, E, P));
        }
    }
}
