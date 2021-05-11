using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class RecipeTests
    {   
        private Recipe recipe;
        [SetUp]
        public void Setup()
        {
            recipe = new Recipe();
            Product product = new Product("Café con leche", 50);
            recipe.FinalProduct = product;
            Step step = new Step(new Product("Leche",20) , 1, new Equipment("Hervidor", 5), 3);
            Step step2 = new Step(new Product("Café",25) , 2, new Equipment("Cafetera", 5), 3);
            recipe.AddStep(step);
            recipe.AddStep(step2);

        }

        [Test]
        
        public void Test1()
        {
            Assert.AreEqual(recipe.GetProductionCost() , 100);
        }
    }
}