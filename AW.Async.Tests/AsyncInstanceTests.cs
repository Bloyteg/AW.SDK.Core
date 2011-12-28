using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AW.Async.Tests
{
    [TestClass]
    public class AsyncInstanceTests
    {
        [TestMethod]
        public void TestLoginWithSuccess()
        {
            var instanceMock = new Mock<IInstance>();

            instanceMock.Setup(instance => instance.Login())
                .Returns(Result.Success)
                .Raises(instance => instance.CallbackLogin += null, instanceMock.Object, Result.Success)
                .Verifiable();

            var testInstance = instanceMock.Object;
            var task = testInstance.LoginAsync();

            task.Wait();
            instanceMock.Verify();
            Assert.AreEqual(Result.Success, task.Result);
        }

        [TestMethod]
        public void TestLoginWithFailure()
        {
            var instanceMock = new Mock<IInstance>();

            instanceMock.Setup(instance => instance.Login())
                .Returns(Result.Success)
                .Raises(instance => instance.CallbackLogin += null, instanceMock.Object, Result.InvalidPassword)
                .Verifiable();

            var testInstance = instanceMock.Object;
            var task = testInstance.LoginAsync();

            task.Wait();
            instanceMock.Verify();
            Assert.AreEqual(Result.InvalidPassword, task.Result);
        }
    }
}
