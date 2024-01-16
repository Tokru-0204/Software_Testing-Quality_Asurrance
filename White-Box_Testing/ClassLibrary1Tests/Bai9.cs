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
    public class Bai9
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            bool ac = o.isTriangle(3, 4, 5);
            bool ex = true;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            bool ac = o.isTriangle(10,5,0);
            bool ex = false;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            bool ac = o.isTriangle(3,4,8);
            bool ex = false;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            bool ac = o.isTriangle(3, 6,2);
            bool ex = false;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method5()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            bool ac = o.isTriangle(10,4,5);
            bool ex = false;
            Assert.AreEqual(ac, ex);
        }

    }
}