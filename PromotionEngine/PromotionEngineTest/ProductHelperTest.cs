using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
namespace SampelDemoAppForGitRepoTest
{
    [TestClass]
    public class ProductHelperTest
    {
        public ProductHelper _productHelper;

        [TestInitialize]
        public void TestInitialize()
        {
            //Initialize objects that _productHelper will be accessing and/required for mocking.
        }

        [TestMethod]
        public void GetProductNameToPriceMapReturnsDictionaryWithAllProducts()
        {

        }

        [TestCleanup]
        public void TestCleaup()
        {
            //De-Initialize used objects in TestInitialize
        }
    }
}
