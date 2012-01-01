using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AW.Async.Tests
{
    [TestClass]
    public class AsyncInstanceTests
    {
        [TestMethod]
        public void TestWorkItemQueueCallbackWithSuccess()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);

            instanceMock.Setup(instance => instance.Login())
                .Returns(Result.Success)
                .Raises(instance => instance.CallbackLogin += null, instanceMock.Object, Result.Success)
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.LoginAsync();

                task.Wait();
                instanceMock.Verify();
                Assert.AreEqual(Result.Success, task.Result);
            }
        }

        [TestMethod]
        public void TestWorkItemQueueCallbackWithFailure()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);

            instanceMock.Setup(instance => instance.Login())
                .Returns(Result.Success)
                .Raises(instance => instance.CallbackLogin += null, instanceMock.Object, Result.InvalidPassword)
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.LoginAsync();

                task.Wait();
                instanceMock.Verify();
                Assert.AreEqual(Result.InvalidPassword, task.Result);
            }
        }

        [TestMethod]
        public void TestWorkItemQueueCallbackWithImmediateFailure()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);

            instanceMock.Setup(instance => instance.Login())
                .Returns(Result.NotInitialized)
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.LoginAsync();

                task.Wait();
                instanceMock.Verify();
                Assert.AreEqual(Result.NotInitialized, task.Result);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void TestWorkItemQueueCallbackWithExceptionFailure()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);

            instanceMock.Setup(instance => instance.Login())
                .Throws(new InstanceSetFailedException())
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.LoginAsync();

                task.Wait();
                instanceMock.Verify();
            }
        }

        [TestMethod]
        public void TestObjectReferenceCounterCallbackWithSuccess()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);
            SetupAttributes(instanceMock);

            instanceMock.Setup(instance => instance.ObjectAdd())
                .Returns(Result.Success)
                .Raises(instance => instance.CallbackObjectResult += null, instanceMock.Object, Result.Success)
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.ObjectAddAsync();

                task.Wait();
                instanceMock.Verify();
                Assert.AreEqual(Result.Success, task.Result);
            }
        }

        [TestMethod]
        public void TestObjectReferenceCounterCallbackWithFailure()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);
            SetupAttributes(instanceMock);

            instanceMock.Setup(instance => instance.ObjectAdd())
                .Returns(Result.Success)
                .Raises(instance => instance.CallbackObjectResult += null, instanceMock.Object, Result.NoSuchObject)
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.ObjectAddAsync();

                task.Wait();
                instanceMock.Verify();
                Assert.AreEqual(Result.NoSuchObject, task.Result);
            }
        }

        [TestMethod]
        public void TestObjectReferenceCounterCallbackWithImmediateFailure()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);
            SetupAttributes(instanceMock);

            instanceMock.Setup(instance => instance.ObjectAdd())
                .Returns(Result.NoConnection)
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.ObjectAddAsync();

                task.Wait();
                instanceMock.Verify();
                Assert.AreEqual(Result.NoConnection, task.Result);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void TestObjectReferenceCounterCallbackWithExceptionFailure()
        {
            var instanceMock = new Mock<IInstance>();
            SetupDisposable(instanceMock);
            SetupAttributes(instanceMock);

            instanceMock.Setup(instance => instance.ObjectAdd())
                .Throws(new InstanceSetFailedException())
                .Verifiable();

            using (var testInstance = instanceMock.Object)
            {
                var task = testInstance.ObjectAddAsync();

                task.Wait();
                instanceMock.Verify();
            }
        }

        #region Helper methods

        private static void SetupDisposable(Mock<IInstance> instanceMock)
        {
            instanceMock.Setup(instance => instance.Dispose())
                .Raises(instance => instance.Disposing += null, instanceMock.Object);
        }

        private static void SetupAttributes(Mock<IInstance> instanceMock)
        {
            var attributeProviderMock = new Mock<IAttributeProvider>();
            attributeProviderMock.SetupAllProperties();

            instanceMock.SetupGet(instance => instance.Attributes)
                        .Returns(attributeProviderMock.Object);
        }

        #endregion
    }
}
