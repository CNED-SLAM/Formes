using Formes.modele;
using NUnit.Framework;

namespace TestFormes
{
    class TestSphere
    {
        private readonly Sphere s = new Sphere(5);

        [Test]
        public void TestAire()
        {
            double aire = s.Aire();
            Assert.AreEqual(314.16d, aire, 0.01d);
        }

        [Test]
        public void TestVolume()
        {
            double volume = s.Volume();
            Assert.AreEqual(523.59d, volume, 0.01d);
        }
    }
}
