using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class RettangoloTests
    {
        private readonly Rettangolo rettangolo;

        public RettangoloTests()
        {
            rettangolo = new Rettangolo();
        }

        [TestMethod()]
        public void Retur_ZeroIfBaseEqualsToZero_Test()
        {
            var result = rettangolo.Area(0, 5);
            Assert.AreEqual(result, 0);
        }

        [TestMethod()]
        public void Return_ZeroIfAltezzaEqualsToZero_Test()
        {
            var result = rettangolo.Area(5, 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod()]
        public void Return_AreaWithValidAltezzaAndBase_Test()
        {
            var latoBase = 5;
            var latoAltezza = 10;
            var area = rettangolo.Area(latoBase, latoAltezza);
            var result = area / latoBase;

            Assert.AreEqual(result, latoAltezza);
        }

        [TestMethod()]
        public void Return_PerimetroWithValidAltezzaAndBase_Test()
        {
            var latoBase = 5;
            var latoAltezza = 10;
            var perimetro = rettangolo.Perimetro(latoBase, latoAltezza);
            var result = perimetro / (latoAltezza + latoBase);

            Assert.AreEqual(result, 2);
        }
    }
}