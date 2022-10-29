
using NUnit.Framework;
using System;
using TestNinja.Mocking;

namespace UnitTestProject.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoService();
            service.FileReader = new FakeFileReader();
            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
