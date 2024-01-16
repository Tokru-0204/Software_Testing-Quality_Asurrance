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
    public class Bai5
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.Average(10, 1);
            double ex = 10;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.Average(15, 2);
            double ex = 7.5;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            double ac = o.Average(15, -5);
            double ex = 0;
            Assert.AreEqual(ac, ex);
        }

    }
}