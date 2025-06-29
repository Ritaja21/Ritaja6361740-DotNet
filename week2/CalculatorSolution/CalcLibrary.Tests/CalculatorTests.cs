using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            // Cleanup if needed
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(10, 20, 30)]
        [TestCase(-1, -1, -2)]
        public void Add_WhenCalled_ReturnsSum(int a, int b, int expected)
        {
            var result = calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("This test is intentionally ignored")]
        public void IgnoredTest()
        {
            Assert.Fail("This should not run");
        }
    }
}
