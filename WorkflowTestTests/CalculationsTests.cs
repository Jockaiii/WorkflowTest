using WorkflowTest;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkflowTest.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(8, Calculations.Add(5,8));
        }
    }
}