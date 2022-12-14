//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace UnitTestProject
{
    //[TestClass]  //this attribute belongs to ms test framework
    //public class ReseervationTests
    //{
    //    //the first part specifies the name of the method on the test,
    //    //the second part is the scenario of our testing, and 
    //    //the third part is the expected behavior.
    //    [TestMethod] //this attribute belongs to ms test framework
    //    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    //    {
    //        //Arrange :
    //        //The Arrange part is where we initialize our objects.
    //        var reseration = new Reservation();

    //        //Act :
    //        // the Act part is where we act on this object, and that basically means we're
    //        //going to call a method, that's the method we're going to test. 

    //        var result = reseration.CanBeCancelledBy(new User { IsAdmin = true });

    //        //Assert

    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_SameUserCancellingTheReseration_ReturnTrue()
    //    {
    //        var user = new User();
    //        var reseration = new Reservation { MadeBy = user };
    //        var result = reseration.CanBeCancelledBy(user);

    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_AnotherUserCancellingTheReseration_ReturnFalse()
    //    {

    //        var reseration = new Reservation { MadeBy = new User() };
    //        var result = reseration.CanBeCancelledBy(new User());

    //        Assert.IsFalse(result);
    //    }
    //}

    [TestFixture] 
    public class ReseervationTests
    {
        //the first part specifies the name of the method on the test,
        //the second part is the scenario of our testing, and 
        //the third part is the expected behavior.
        [Test] 
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange :
            //The Arrange part is where we initialize our objects.
            var reseration = new Reservation();

            //Act :
            // the Act part is where we act on this object, and that basically means we're
            //going to call a method, that's the method we're going to test. 

            var result = reseration.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert

            // many ways to assert

            Assert.IsTrue(result);
            //Assert.That(result , Is.True);  
            //Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReseration_ReturnTrue()
        {
            var user = new User();
            var reseration = new Reservation { MadeBy = user };
            var result = reseration.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReseration_ReturnFalse()
        {

            var reseration = new Reservation { MadeBy = new User() };
            var result = reseration.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
