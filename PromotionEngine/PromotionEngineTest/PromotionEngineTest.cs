using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace SampelDemoAppForGitRepoTest
{
    [TestClass]
    public class PromotionEngineTest
    {
        public PromotionEngines promotionEngine;

        public PromotionEngineTest()
        {
            promotionEngine = new PromotionEngines();
        }

        [TestMethod]
        public void VerifyGetTotalPriceForCheckOutReturnsCorrectValue()
        {
            // code to specify total number of products,products - A,B,C,D and thiir prices.
            Assert.AreEqual(280, promotionEngine.GetTotalPriceForCheckOut());
        }

        [TestCleanup]
        public void TestCleaup()
        {
            promotionEngine = null;
        }
    }
}
