using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic.Algorithms;
using System.Collections.Generic;
using System.IO;

namespace Vitoys.Tests
{
    [TestClass]
    public class TestValidationEngine
    {

        private static IValidationAlgorithmEngine engine;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            engine = new ValidationAlgorithmEngine();
        }

        [TestInitialize]
        public void BeforeEveryTest()
        {

        }

        [TestCleanup]
        public void AfterEveryTest()
        {

        }

        [TestMethod]
        public void TestMod10()
        {
            Assert.IsTrue(engine.isValid("000017", AlgorithmType.Mod10));
            Assert.IsFalse(engine.isValid("000018", AlgorithmType.Mod10));

            Assert.IsTrue(engine.isValid("000116", AlgorithmType.Mod10));
            Assert.IsTrue(engine.isValid("000116", AlgorithmType.Mod10));
            Assert.IsTrue(engine.isValid("00015257", AlgorithmType.Mod10));

            Assert.IsTrue(engine.isValid("00017923", AlgorithmType.Mod10));
            Assert.IsTrue(engine.isValid("00076531", AlgorithmType.Mod10));
        }

        [TestMethod]
        public void TestMod_97_10()
        {
            //Bank Accounts
            Assert.IsTrue(engine.isValid("1110195681000188", AlgorithmType.Mod_97_10));
            Assert.IsTrue(engine.isValid("1701003025751381", AlgorithmType.Mod_97_10));
            Assert.IsTrue(engine.isValid("2020000090180975", AlgorithmType.Mod_97_10));
            Assert.IsFalse(engine.isValid("2020000090180955", AlgorithmType.Mod_97_10));
        }

        [TestMethod]
        public void TestValidationOfFiskalNo()
        {
            Assert.IsTrue(engine.isValid("600588977", AlgorithmType.FiskalNr));
            Assert.IsTrue(engine.isValid("600016762", AlgorithmType.FiskalNr));

            Assert.IsFalse(engine.isValid("600578977", AlgorithmType.FiskalNr));
            Assert.IsFalse(engine.isValid("600216762", AlgorithmType.FiskalNr));
        }

        [ClassCleanup]
        public static void Cleanup()
        {

        }
    }
}
