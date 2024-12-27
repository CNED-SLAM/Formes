using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Formes.modele.Tests
{
    [TestClass()]
    public class CarreTests
    {
        private Carre c = new Carre(5);

        [TestMethod()]
        public void CarreTest()
        {

        }

        [TestMethod()]
        public void PerimetreTest()
        {
            double perimetre = c.Perimetre();
            Assert.AreEqual(20, perimetre);
        }

        [TestMethod()]
        public void AireTest()
        {
            double aire = c.Aire();
            Assert.AreEqual(25, aire);
        }
    }
}