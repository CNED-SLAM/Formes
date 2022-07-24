using Formes.modele;
using NUnit.Framework;

namespace TestFormes
{
    class TestCube
    {
        private readonly Cube c = new Cube(5);

        [Test]
        public void TestAire()
        {
            double aire = c.Aire();
            Assert.AreEqual(150, aire);
        }

        [Test]
        public void TestVolume()
        {
            double volume = c.Volume();
            Assert.AreEqual(125, volume);
        }
    }
}
