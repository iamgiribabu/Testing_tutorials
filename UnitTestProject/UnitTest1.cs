using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace UnitTestProject
{
    [TestClass]  //this attribute belongs to ms test framework
    public class ReseervationTests
    {
        //the first part specifies the name of the method on the test,
        //the second part is the scenario of our testing, and 
        //the third part is the expected behavior.
        [TestMethod]
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

            Assert.IsTrue(result);
        }
    }
}
