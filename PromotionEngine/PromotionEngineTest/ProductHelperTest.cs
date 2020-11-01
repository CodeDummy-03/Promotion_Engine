using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngineTest
{
    [TestClass]
    public class ProductHelperTest
    {
        public ProductHelper productHelper;
        public List<string> productNamesToVerify;

        [TestInitialize]
        public void TestInitialize()
        {
            productHelper = new ProductHelper();
            productNamesToVerify = new List<string> { "A", "B", "C", "D" };
        }

        [TestMethod]
        public void GetProductNameToPriceMapReturnsDictionaryWithAllProducts()
        {
            var productNameToPriceMap = productHelper.GetProductNameToPriceMap();

            Assert.AreEqual(productNamesToVerify.Count, productNameToPriceMap.Count);

            foreach (string productName in productNamesToVerify)
            {
                Assert.IsTrue(productNameToPriceMap.ContainsKey(productName));
            }
        }

        [TestCleanup]
        public void TestCleaup()
        {
            productHelper = null;
            productNamesToVerify = null;
        }
    }
}
