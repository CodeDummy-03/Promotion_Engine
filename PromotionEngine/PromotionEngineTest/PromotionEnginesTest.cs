using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;

namespace SampelDemoAppForGitRepoTest
{
    [TestClass]
    public class PromotionEnginesTest
    {
        public PromotionEngines promotionEngine;

        [TestInitialize]
        public PromotionEnginesTest()
        {
            promotionEngine = new PromotionEngines();
        }

        [TestMethod]
        public void VerifyGetTotalPriceForCheckOutReturnsCorrectValue()
        {
            promotionEngine.ProductNameToPriceMap =
                new Dictionary<string, int>() { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
            promotionEngine.TotalNoOfProductsBought = 10;
            promotionEngine.NoOfProductABought = 3;
            promotionEngine.NoOfProductBBought = 5;
            promotionEngine.NoOfProductCBought = 1;
            promotionEngine.NoOfProductDBought = 1;
            Assert.AreEqual(280, promotionEngine.GetTotalPriceForCheckOut());
        }

        [TestCleanup]
        public void TestCleaup()
        {
            promotionEngine = null;
        }
    }
}
