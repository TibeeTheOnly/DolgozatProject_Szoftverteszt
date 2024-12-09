using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatProject.Tests
{
    [TestFixture]
    internal class DolgozatTeszt
    {
        [Test]
        public void Test_HelyesKimenet()
        {
            // Arrange
            var expected = 10; // Példa elvárt kimenet
            var input = 5; // Példa bemenet

            // Act
            var result = Calculate(input); // A tesztelendő metódus

            // Assert
            Assert.Equals(expected, result);
        }

        [Test]
        public void Test_HelytelenBemenet()
        {
            // Arrange
            var input = -1; // Helytelen bemenet

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculate(input));
        }

        private int Calculate(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "A bemenet nem lehet negatív.");
            }
            return value * 2; // Példa logika
        }

    }
}
