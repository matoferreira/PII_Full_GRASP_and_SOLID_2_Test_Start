using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class ProductTests
    {
        private Product product;

        [SetUp]
        public void Setup()
        {
            this.product = new Product("",1);
        }

        [Test]
        
        public void TestDescripcionNoVacia()
        {
            product.Description = "Nombre";
            Assert.IsNotEmpty(product.Description);
        }

        [Test]

        public void TestDescripcionNoNULA()
        {
            Assert.IsNotNull(product.Description);
        }

        [Test]
        public void TestUnitCostPositivoOCero()
        {
            Assert.IsTrue(product.UnitCost >= 0);
        }
        [Test]
        public void TestCostCero()
        {
            Assert.IsTrue(product.UnitCost == 0, "TEST DEBE DAR ERROR si no unitcost es cero");
        }
    }
}