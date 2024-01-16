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
    public class Bai6
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(2000, 3);
            double ex = 31;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(2000, 4);
            double ex = 30;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(2000, 13);
            double ex = 0;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(2000, 2);
            double ex = 29;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method5()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(1900, 2);
            double ex = 28;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method6()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(2012, 2);
            double ex = 29;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method7()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.daysInMonth(2013, 2);
            double ex = 28;
            Assert.AreEqual(ac, ex);
        }
    }
}