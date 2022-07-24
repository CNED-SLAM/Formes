using Formes.modele;
using NUnit.Framework;

namespace TestFormes
{
    class TestCercle
    {
        private readonly Cercle c = new Cercle(5);

        [Test]
        public void TestPerimetre()
        {
            double perimetre = c.Perimetre();
            Assert.AreEqual(31.41d, perimetre, 0.01d);
        }

        [Test]
        public void TestAire()
        {
            double aire = c.Aire();
            Assert.AreEqual(78.53d, aire, 0.01d);
        }
    }
}
