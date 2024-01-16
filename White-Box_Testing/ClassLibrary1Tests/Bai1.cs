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
    public class Bai1
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            int ac = o.getPositionOf2Cir(5, 5, 0);
            int ex = 0;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            int ac = o.getPositionOf2Cir(5, 5, 1);
            int ex = 3;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            int ac = o.getPositionOf2Cir(5, 10, 0);
            int ex = 1;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            int ac = o.getPositionOf2Cir(10, 5, 0);
            int ex = 2;
            Assert.AreEqual(ac, ex);
        }

    }
}