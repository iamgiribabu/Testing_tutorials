
using NUnit.Framework;
using System;
using TestNinja.Mocking;

namespace UnitTestProject.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void TestMethod1()
        {
            var service = new VideoService();

            var result = service.ReadVideoTitle(new FakeFileReader());

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
