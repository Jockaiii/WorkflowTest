﻿using WorkflowTest;
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
            Assert.AreEqual(13, Calculations.Add(5,8));
            Assert.AreEqual(12, Calculations.Add(5,8));
        }
    }
}