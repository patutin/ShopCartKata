using Kata.ShoppingCart;
using NSubstitute;
using NUnit.Framework;
using System;

namespace Kata.ShoppingCart.Tests.NUnit
{
    [TestFixture]
    public class CheckoutTests
    {


        [SetUp]
        public void SetUp()
        {

        }

        private Checkout CreateCheckout()
        {
            return new Checkout();
        }

        [Test]
        public void GetTotal_ForString_DoesntThrowExcetion()
        {
            // Arrange
            var checkout = this.CreateCheckout();
            string items = "null";


            // Assert
            Assert.DoesNotThrow(() => checkout.GetTotal(
                items));
        }
        
        
        [TestCase("A",50)]
        [TestCase("B",30)]
        [TestCase("C",20)]
        [TestCase("D",15)]
        public void GetTotal_ForOneLetterString_ReturnsItPrice(string items, double expected)
        {
            // Arrange
            var checkout = this.CreateCheckout();

            var result = checkout.GetTotal(items);


            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        
        [TestCase("AB",80)]
        [TestCase("ABC",100)]
        [TestCase("ABCD",115)]
        public void GetTotal_ForSeveralDiffrentLettersString_ReturnsItSumPrice(string items, double expected)
        {
            // Arrange
            var checkout = this.CreateCheckout();

            var result = checkout.GetTotal(items);


            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        
        
        [TestCase("ABLLL",80)]
        [TestCase("NNNABC",100)]
        [TestCase("VAVBCVDV",115)]
        public void GetTotal_ForSeveralDiffrentLettersString_SkipUnknownProductCodes(string items, double expected)
        {
            // Arrange
            var checkout = this.CreateCheckout();

            var result = checkout.GetTotal(items);


            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
