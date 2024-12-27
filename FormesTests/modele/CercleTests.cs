using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Formes.modele.Tests
{
    [TestClass()]
    public class CercleTests
    {
        private Cercle c = new Cercle(5);

        [TestMethod()]
        public void CercleTest()
        {

        }

        [TestMethod()]
        public void PerimetreTest()
        {
            double perimetre = c.Perimetre();
            Assert.AreEqual(31.41d, perimetre, 0.01d);
        }

        [TestMethod()]
        public void AireTest()
        {
            double aire = c.Aire();
            Assert.AreEqual(78.53d, aire, 0.01d);
        }
    }
}