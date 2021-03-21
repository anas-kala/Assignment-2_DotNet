using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayGround;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(Program.Add(3,4)==7);
        }
    }
}