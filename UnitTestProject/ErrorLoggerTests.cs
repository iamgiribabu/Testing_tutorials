using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void TestMethod1()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }
    }
}
