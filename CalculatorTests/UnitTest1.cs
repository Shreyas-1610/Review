using FifthReview;

namespace CalculatorTests
{
    public class Tests
    {
        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void Test1()
        {
            int a = 5, b = 3;
            var expected = 8;
            var actual = cal.Add(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            int a = 5, b = 3;
            var expected = 2;
            var actual = cal.Sub(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test3()
        {
            int a = 5, b = 3;
            var expected = 15;
            var actual = cal.Mult(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test4()
        {
            int a = 6, b = 3;
            var expected = 2.0;
            var actual = cal.Div(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}