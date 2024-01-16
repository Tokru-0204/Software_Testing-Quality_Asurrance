using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Bai8
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float ac = o.checkRange(4, 10, 5);
                float ex = 5;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a must be less than or equal to b";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float ac = o.checkRange(10,5,5);
                float ex = 5;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a must be less than or equal to b";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float ac = o.checkRange(4, 10, 3);
                float ex = 4;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a must be less than or equal to b";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method4()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float ac = o.checkRange(4, 5,10);
                float ex = 5;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a must be less than or equal to b";
                Assert.AreEqual(ac, ex);
            }
        }
    }
}