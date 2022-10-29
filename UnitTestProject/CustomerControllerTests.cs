
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace UnitTestProject
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
           var result =  controller.GetCustomer(0);

            //notfound
            Assert.That(result, Is.TypeOf<NotFound>());

            //notfound or one of its derivatives
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.Not.Zero);
        }
    }
}
