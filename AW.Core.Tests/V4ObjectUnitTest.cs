using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Core.Tests
{
    /// <summary>
    /// Summary description for V4ObjectUnitTest
    /// </summary>
    [TestClass]
    public class V4ObjectUnitTest
    {
        public V4ObjectUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_Particle_GetData()
        {
            var particle = new Particle
                               {
                                   AssetList = "1234567",
                                   Name = "1234567890"
                               };
            var asData = particle.GetData();

            Assert.AreEqual(220, asData.Length);
            Assert.AreEqual("1234567", Encoding.UTF8.GetString(asData, 202, 7));
            Assert.AreEqual("1234567890", Encoding.UTF8.GetString(asData, 209, 10));
        }
    }
}
