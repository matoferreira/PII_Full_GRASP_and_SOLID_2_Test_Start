using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class StepTests
    {
        private Step step;
        private Product product;
        private Equipment equipment;

        [SetUp]
        public void Setup()
        {
            this.product = new Product("nombre", 1);
            this.equipment = new Equipment("Equip name", 1);
            this.step = new Step(product, 1, equipment, 1);

        }

        [Test]

        public void TestProductoNoNulo()
        {
            Assert.IsNotNull(step.Input);
        }

        [Test]

        public void TestProductoNulo()
        {
            Assert.IsNull(step.Input, "ESTE TEST DEBE DAR ERROR sino el product es NULL");
        }

        [Test]

        public void TestEquipmentNulo()
        {
            Assert.IsNull(step.Equipment, "ESTE TEST DEBE DAR ERROR sino el equipment es nulo");
        }

        [Test]

        public void TestEquipmentNONulo()
        {
            Assert.IsNotNull(step.Equipment);
        }

        [Test]

        public void TestQuantityPositivoOCero()
        {
            Assert.IsTrue(step.Quantity >= 0);
        }
        
        [Test]

        public void TestTimePositivoOCero()
        {
            Assert.IsTrue(step.Time >= 0);
        }

        [Test]

        public void TestGetStepcostCorrecto() //Utilizo todos los valores como numeros primos xq x teo 
                                              //Fundamentañl de la aritmetica el resultado de mult y sumas
                                              //de primos es único
        {
            product.UnitCost = 2;
            step.Quantity = 3;
            equipment.HourlyCost = 5;
            step.Time = 7;
            Assert.AreEqual(41, step.GetStepCost());
        }

        [Test]

        public void TestTodosLosValoresSonPositivos()
        {
            Assert.IsTrue(product.UnitCost > 0 && step.Quantity > 0 && equipment.HourlyCost > 0 && step.Time > 0);
        }

    }
}