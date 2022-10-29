
using NUnit.Framework;
using System;
using System.Linq;

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

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));


            // check whether it contains in array or not without respect to order
            Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5 }));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
