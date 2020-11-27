using Kata.ShoppingCart;
using NSubstitute;
using NUnit.Framework;
using System;

namespace Kata.ShoppingCart.Tests.NUnit
{
    [TestFixture]
    public class DiscauntApplyerTests
    {


        [SetUp]
        public void SetUp()
        {

        }

        private DiscauntApplyer CreateDiscauntApplyer()
        {
            return new DiscauntApplyer();
        }

        [Test]
        public void FindDiscaunt_ForSingleDodes_ReturnSameSting()
        {
            // Arrange
            var discauntApplyer = this.CreateDiscauntApplyer();
            string elemetns = "ABC";

            // Act
            var result = discauntApplyer.FindDiscaunt(
                elemetns);

            // Assert
            Assert.That(result.elements, Is.EqualTo(elemetns));
        }
        
        [Test]
        public void FindDiscaunt_ForCorrectElements_RemoveItFromString()
        {
            // Arrange
            var discauntApplyer = this.CreateDiscauntApplyer();
            string elemetns = "AAABC";
            string expected = "BC";

            // Act
            var result = discauntApplyer.FindDiscaunt(
                elemetns);

            // Assert
            Assert.That(result.elements, Is.EqualTo(expected));
        }
    }
}
