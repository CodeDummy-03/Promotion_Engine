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
            //Initialize objects that promotionEngine will be accessing and/required for mocking.
        }

        [TestMethod]
        public void VerifyGetTotalPriceForCheckOutReturnsCorrectValue()
        {
            
        }

        [TestCleanup]
        public void TestCleaup()
        {
            //De-Initialize used objects in TestInitialize
        }
    }
}
