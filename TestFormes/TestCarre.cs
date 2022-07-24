using Formes.modele;
using NUnit.Framework;

namespace TestFormes
{
    public class TestCarre
    {
        private Carre c = new Carre(5);

        [Test]
        public void TestPerimetre()
        {
            double perimetre = c.Perimetre();
            Assert.AreEqual(20, perimetre);
        }

        [Test]
        public void TestAire()
        {
            double aire = c.Aire();
            Assert.AreEqual(25, aire);
        }
    }
}