using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Formes.modele.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private Cube c = new Cube(5);

        [TestMethod()]
        public void CubeTest()
        {

        }

        [TestMethod()]
        public void AireTest()
        {
            double aire = c.Aire();
            Assert.AreEqual(150, aire);
        }

        [TestMethod()]
        public void VolumeTest()
        {
            double volume = c.Volume();
            Assert.AreEqual(125, volume);
        }
    }
}