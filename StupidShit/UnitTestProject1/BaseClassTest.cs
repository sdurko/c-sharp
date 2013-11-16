using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StupidShit;

namespace UnitTestProject1
{
    [TestClass]
    public class BaseClassTest
    {
        private BaseClass _base;

        
        [TestInitialize]
        public void TestSetup()
        {
            _base = new BaseClass();
        }

        [TestCategory("BaseClassTests")]
        [TestMethod]
        public void CallSteve()
        {
            var result = _base.Steve(5);
            Assert.AreEqual("Base-Steve",result);
        }

        [TestCategory("BaseClassTests")]
        [TestMethod]
        public void Jack_NoParams_ReturnsJacky()
        {
            var result = _base.Jack();
            Assert.AreEqual("Jacky", result);
        }

        //IsValidFileName_validFile_ReturnsTrue()

        [TestCategory("BaseClassTests")]
        [TestMethod]
        public void Steve_BasicCall_MatchesResult()
        {
            Assert.AreEqual("Base-Steve",_base.Steve(5));
        }

        [TestCategory("BaseClassTests")]
        [TestMethod]
        public void Dispose_Called_CleansUp()
        {
            _base.Dispose();
            Assert.IsTrue(true);

        }
    }
}
