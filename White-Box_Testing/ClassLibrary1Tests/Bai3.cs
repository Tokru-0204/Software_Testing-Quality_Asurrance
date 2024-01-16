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
    public class Bai3
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
               ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                int ac = o.max(4, 5, 6);
                int ex = 6;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a, b, and c must be greater than 0";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                int ac = o.max(4, -5, 6);
                int ex = 6;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a, b, and c must be greater than 0";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                int ac = o.max(6,5,4);
                int ex = 6;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a, b, and c must be greater than 0";
                Assert.AreEqual(ac, ex);
            }
        }
    }
}