using System.Reflection;
using System.Runtime.InteropServices;
using AW;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Utilities.Serialization;

namespace AW.Core.Tests
{
    
    
    /// <summary>
    ///This is a test class for V_ObjectSerializerTest and is intended
    ///to contain all V_ObjectSerializerTest Unit Tests
    ///</summary>
    [TestClass]
    public class V4ObjectSerializerTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        private static Particle SetupParticle()
        {
            return new Particle
                       {
                           Acceleration =
                               {
                                   Maximum =
                                       {
                                           XMagnitude = -1,
                                           YMagnitude = 1,
                                           ZMagnitude = 0
                                       },
                                   Minimum =
                                       {
                                           XMagnitude = -2,
                                           YMagnitude = 2,
                                           ZMagnitude = 2
                                       }
                               },
                           Flags =
                               {
                                   ApplyRotation = true,
                                   Gravity = true,
                                   ZoneCollision = true
                               },
                           EmitterLifespan = 1000,
                           FadeIn = 100,
                           FadeOut = 1000,
                           AssetList = "string1:string2, string3, string4",
                           Name = "TestParticle",
                           ColorEnd = Color.FromString("FFFF00")
                       };
        }

        private static Cloth SetupCloth()
        {
            return new Cloth();
        }

        [TestMethod]
        public void Test_StreamSerialization_Particle()
        {
            var input = SetupParticle();
            byte[] buffer;
            using(MemoryStream stream = new MemoryStream())
            {
                var serializer = new V4ObjectSerializer<Particle>();
                serializer.Serialize(stream, input);
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
            }

            var structLength = Marshal.SizeOf(((FieldInfo)(SerializationHelper.GetFieldSizeProvider<Particle>())).FieldType);

            Assert.IsNotNull(buffer);
            Assert.IsTrue(structLength <= buffer.Length);
        }

        [TestMethod]
        public void Test_StreamSerialization_Cloth()
        {
            var input = SetupCloth();
            byte[] buffer;
            using (MemoryStream stream = new MemoryStream())
            {
                var serializer = new V4ObjectSerializer<Cloth>();
                serializer.Serialize(stream, input);
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
            }

            var structLength = Marshal.SizeOf(((FieldInfo)(SerializationHelper.GetFieldSizeProvider<Cloth>())).FieldType);

            Assert.IsNotNull(buffer);
            Assert.IsTrue(structLength <= buffer.Length);
        }
    }
}
