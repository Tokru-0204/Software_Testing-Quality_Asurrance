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
    public class Bai7
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                string ac = o.Solve(2, 5, 2);
                string ex = "-2, -0.5";
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                string ac = o.Solve(3,4,5);
                string ex = "no results";
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                string ac = o.Solve(2,4,2);
                string ex = "-1";
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method4()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                string ac = o.Solve(0,4,5);
                string ex = "-2, -0.5";
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ac, ex);
            }
        }
    }
}