using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommTests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mockMailSender;
        private CustomerComm customerComm;

        [OneTimeSetUp]
        public void Setup()
        {
            mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            customerComm = new CustomerComm(mockMailSender.Object);
        }

        [Test]
        public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSent()
        {
            bool result = customerComm.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
