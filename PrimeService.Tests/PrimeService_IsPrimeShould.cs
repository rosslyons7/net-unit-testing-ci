using NUnit.Framework;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {

        private PrimeService _primeService;

        [SetUp]
        public void Setup() {

            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse() {

            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test]
        public void IsPrime_InputIs2_ReturnTrue() {

            var result = _primeService.IsPrime(2);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPrime_InputIs3_ReturnTrue() {
            var result = _primeService.IsPrime(3);
            Assert.That(result, Is.True);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_InputIsLessThan2_ReturnFalse(int x) {
            
            var result = _primeService.IsPrime(x);
            Assert.That(result == false);
        }

        [TestCase(5)]
        [TestCase(7)]
        [TestCase(5)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(59)]
        public void IsPrime_InputIsPrime_ReturnTrue(int x) {
            var result = _primeService.IsPrime(x);
            Assert.That(result == true);
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(44)]
        [TestCase(1494858)]
        public void IsPrime_InputIsNotPrime_ReturnFalse(int x) {
            var result = _primeService.IsPrime(x);
            Assert.That(result == false);
        }

    }
}