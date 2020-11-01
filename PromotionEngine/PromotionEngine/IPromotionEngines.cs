
using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotionEngines
    {
        public int TotalNoOfProductsBought { get; set; }
        public int NoOfProductABought { get; set; }
        public int NoOfProductBBought { get; set; }
        public int NoOfProductCBought { get; set; }
        public int NoOfProductDBought { get; set; }
        public Dictionary<string, int> ProductNameToPriceMap { get; set; }

        int GetTotalPriceForCheckOut();
    }
}
