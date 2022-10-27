
using NUnit.Framework;
using System;


namespace UnitTestProject
{
    [TestFixture]
    public class MathTests
    {
        private TestNinja.Fundamentals.Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new TestNinja.Fundamentals.Math();
        }

        [Test]
        
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3)); 
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int exceptedResult)
        {
           

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(exceptedResult));
        }

        [Test]
        [Ignore("not in use")]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondtArgument()
        {


            var result = _math.Max(5, 10);

            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        [Ignore("not in use")]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {


            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }


    }
}
