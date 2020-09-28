using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoCodePhanHe.Management;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Management.Tests
{
    [TestClass()]
    public class MonHocManagerTests
    {
        [TestMethod()]
        public void updateMonHocTest()
        {
            MonHocManager mh = new MonHocManager();
            Boolean check= mh.UpdateMonHoc("PRN321", "FA21", "C#", 1, 2, 3);
            Assert.AreEqual(true, check);
        }

        [TestMethod()]
        public void insertMonHocTest1()
        {
            MonHocManager mm = new MonHocManager();
            Assert.AreEqual(true, mm.insertMonHoc("Prj123", "FA20", "C#", 1, 2, 3));
        }
    }
}