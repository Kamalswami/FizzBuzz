using System.Collections.Generic;
using System.Linq;
using HelperLib;
using NUnit.Framework;

namespace HelperLibTests
{
    [TestFixture]
    public class HelperTests
    {
        private Helper _h;

        [SetUp]
        public void Init()
        {
            _h = new Helper();
        }

        [Test]
        public void Count_Should_Be_Zero()
        {
            Assert.AreEqual(0, _h.FizzBuzz(1, 0).Count());
        }

        [Test]
        public void Count_Should_Be_One()
        {
            Assert.AreEqual(1, _h.FizzBuzz(0, 0).Count());
        }

        [Test]
        public void Count_Should_Be_Fifteen()
        {
            Assert.AreEqual(15, _h.FizzBuzz(1, 15).Count());
        }

        [Test]
        public void Verify_Data_Process_Method_FuzzBizz()
        {
            IEnumerable<string> expected = new[]
                {
                    "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
                };
            Assert.IsTrue(expected.SequenceEqual(_h.FizzBuzz(1, 15)));
        }
    }
}
