using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Formes.modele.Tests
{
    [TestClass()]
    public class SphereTests
    {
        private Sphere s = new Sphere(5);

        [TestMethod()]
        public void SphereTest()
        {

        }

        [TestMethod()]
        public void AireTest()
        {
            double aire = s.Aire();
            Assert.AreEqual(314.16d, aire, 0.01d);
        }

        [TestMethod()]
        public void VolumeTest()
        {
            double volume = s.Volume();
            Assert.AreEqual(523.59d, volume, 0.01d);
        }
    }
}