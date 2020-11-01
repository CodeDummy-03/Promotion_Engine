using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionEngines : IPromotionEngines
    {
        public int TotalNoOfProductsBought { get; set; }
        public int NoOfProductABought { get; set; }
        public int NoOfProductBBought { get; set; }
        public int NoOfProductCBought { get; set; }
        public int NoOfProductDBought { get; set; }
        public Dictionary<string, int> ProductNameToPriceMap { get; set; }

        static void Main(string[] args)
        {
            
        }

        public int GetTotalPriceForCheckOut()
        {
            var priceofA = ProductNameToPriceMap["A"];
            var priceofB = ProductNameToPriceMap["B"];
            var priceofC = ProductNameToPriceMap["C"];
            var priceofD = ProductNameToPriceMap["D"];

            var totalPriceofA = (NoOfProductABought / 3) * 130 + (NoOfProductABought % 3 * priceofA);
            var totalPriceofB = (NoOfProductBBought / 2) * 45 + (NoOfProductBBought % 2 * priceofB);

            var noOfProductCDCombo = 0;
            if (NoOfProductCBought > 0 && NoOfProductDBought > 0)
            {
                noOfProductCDCombo = Math.Min(NoOfProductCBought, NoOfProductDBought);
            }

            var totalPriceofC = (Math.Abs(NoOfProductCBought - noOfProductCDCombo) * priceofC);
            var totalPriceofD = (Math.Abs(NoOfProductDBought - noOfProductCDCombo) * priceofD);
            var totalPriceofCDCombo = noOfProductCDCombo * 30;

            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD + totalPriceofCDCombo;
        }
    }
}
