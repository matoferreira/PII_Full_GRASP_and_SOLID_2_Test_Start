using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class EquipmentTests
    {
        private Equipment equipment;
        [SetUp]
        public void Setup()
        {
            this.equipment = new Equipment("Equip name", 1);
        }

        [Test]

        public void TestNombreNoNulo()
        {
            Assert.IsNotNull(equipment.Description);
        }

         [Test]

        public void TestNombreNulo()
        {
            Assume.That(equipment.Description == null);
            Assert.IsNull(equipment.Description);
        }

        [Test]

        public void TestNombreNoVacio()
        {
            Assert.IsNotEmpty(equipment.Description);
        }

        [Test]

        public void TestNombreVacio()
        {
            Assert.IsEmpty(equipment.Description, "Test debe dar error o sino el nombre esta vacio");
        }

        [Test]
        public void TestCostPositivoOCero()
        {
            Assert.IsTrue(equipment.HourlyCost >= 0);
        }
        [Test]
        public void TestCostCero()
        {
            Assert.IsTrue(equipment.HourlyCost == 0, "TEST DEBE DAR ERROR sino hourlycost es cero");
        }
    }
}