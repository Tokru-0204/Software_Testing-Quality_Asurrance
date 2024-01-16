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
    public class Bai4
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(5, 5, 5);
            string ex = "Triangle is Equilateral";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(3,4,8);
            string ex = "Not a Triangle";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(8,3,4);
            string ex = "Not a Triangle";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(3,8,4);
            string ex = "Not a Triangle";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method5()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(3,4, 5);
            string ex = "Triangle is Scalene";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method6()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(5, 5, -2);
            string ex = "Not a Triangle";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method7()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(5, 5, 2);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method8()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(5, 11, 5);
            string ex = "Not a Triangle";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method9()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(5, 6, 5);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method10()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(11, 5, 5);
            string ex = "Not a Triangle";
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method11()
        {
            ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
            string ac = o.Triangle(6, 5, 5);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ac, ex);
        }
    }
}