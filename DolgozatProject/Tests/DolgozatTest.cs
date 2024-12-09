using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatProject
{
    [TestFixture]
    public class DolgozatTest
    {
        private Dolgozat dolgozat;

        [Test]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void PontFelvesz_ValidInput_AddsPoint()
        {
            dolgozat.PontFelvesz(75);
            Assert.AreEqual(1, dolgozat.Pontok.Count);
            Assert.AreEqual(75, dolgozat.Pontok[0]);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void PontFelvesz_InvalidInput_ThrowsException()
        {
            dolgozat.PontFelvesz(101);
        }

        [Test]
        public void MindenkiMegirta_NoNegativePoints_ReturnsFalse()
        {
            dolgozat.PontFelvesz(50);
            Assert.IsFalse(dolgozat.MindenkiMegirta());
        }

        [Test]
        public void MindenkiMegirta_OneNegativePoint_ReturnsTrue()
        {
            dolgozat.PontFelvesz(-1);
            Assert.IsTrue(dolgozat.MindenkiMegirta());
        }

        [Test]
        public void Bukas_CorrectCount_ReturnsCorrectValue()
        {
            dolgozat.PontFelvesz(30);
            dolgozat.PontFelvesz(40);
            dolgozat.PontFelvesz(60);
            Assert.AreEqual(2, dolgozat.Bukas);
        }

        [Test]
        public void Elegseges_CorrectCount_ReturnsCorrectValue()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(55);
            Assert.AreEqual(2, dolgozat.Elegseges);
        }

        [Test]
        public void Kozepes_CorrectCount_ReturnsCorrectValue()
        {
            dolgozat.PontFelvesz(65);
            dolgozat.PontFelvesz(70);
            Assert.AreEqual(2, dolgozat.Kozepes);
        }

        [Test]
        public void Jo_CorrectCount_ReturnsCorrectValue()
        {
            dolgozat.PontFelvesz(75);
            dolgozat.PontFelvesz(80);
            Assert.AreEqual(2, dolgozat.Jo);
        }

        [Test]
        public void Jeles_CorrectCount_ReturnsCorrectValue()
        {
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(90);
            Assert.AreEqual(2, dolgozat.Jeles);
        }

        [Test]
        public void Gyanus_ValidKivalok_ReturnsTrue()
        {
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(90);
            Assert.IsTrue(dolgozat.Gyanus(1));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Gyanus_InvalidKivalok_ThrowsException()
        {
            dolgozat.Gyanus(-1);
        }

        [Test]
        public void Ervenytelen_HalfOrMoreInvalidPoints_ReturnsTrue()
        {
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(60);
            Assert.IsTrue(dolgozat.Ervenytelen);
        }

        [Test]
        public void Ervenytelen_LessThanHalfInvalidPoints_ReturnsFalse()
        {
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(60);
            Assert.IsFalse(dolgozat.Ervenytelen);
        }
    }
}
