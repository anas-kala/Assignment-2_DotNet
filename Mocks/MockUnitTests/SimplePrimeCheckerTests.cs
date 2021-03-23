using Microsoft.VisualStudio.TestTools.UnitTesting;
using MocksExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksExercise.Tests
{
    [TestClass()]
    public class SimplePrimeCheckerTests
    {
        [TestMethod]
        public void TestCheck()
        {
            var primeChecker = new SimplePrimeChecker();

            Assert.IsFalse(primeChecker.IsPrime(1));
            Assert.IsFalse(primeChecker.IsPrime(4));

            Assert.IsTrue(primeChecker.IsPrime(2));
            Assert.IsTrue(primeChecker.IsPrime(11));
            Assert.IsTrue(primeChecker.IsPrime(199));
            Assert.IsTrue(primeChecker.IsPrime(1259));
            Assert.IsTrue(primeChecker.IsPrime(3271));
        }
    }
}