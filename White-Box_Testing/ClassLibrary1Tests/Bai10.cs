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
    public class Bai10
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float[] ac = o.centerImage(10, 10, 5, 5);
                float[] ex = new float[] { 0, 0 };
                 for (int i = 0; i < ex.Length; i++)
                {
                    Assert.AreEqual(ex[i], ac[i], 0.001);
                }
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float[] ac = o.centerImage(6, 6, 10, 10);
                float[] ex = new float[] { 2, 2 };
                for (int i = 0; i < ex.Length; i++)
                {
                    Assert.AreEqual(ex[i], ac[i], 0.001);
                }
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.TestModule03 o = new ClassLibrary1.TestModule03();
                float[] ac = o.centerImage(10, 10, 0, 5);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ac, ex);
            }
        }
    }
}