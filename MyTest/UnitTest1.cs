using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyM;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1__0_0_0()
        {
            double a = 0, b = 0, c = 0;
            string expResult = "любое число";
          KVADR kv=new KVADR(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);

        }
        [TestMethod]
        public void Test1__1_1_1()
        {
            double a = 1, b = 1, c = 1;
            string expResult = "нет корней";
            KVADR kv = new KVADR(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);

        }
        [TestMethod]
        public void Test1__1_1_min2()
        {
            double a = 1, b = 1, c =-2;
            string expResult = "x1=1   x2=-2";
            KVADR kv = new KVADR(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);

        }
        [TestMethod]
        public void Test1__0_1_min1()
        {
            double a = 0, b = 1, c = -1;
            string expResult = "x=1";
            KVADR kv = new KVADR(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);

        }
    }
}
