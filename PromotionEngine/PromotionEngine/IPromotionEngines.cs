
using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotionEngines
    {
        int TotalNoOfProductsBought { get; set; }
        int NoOfProductABought { get; set; }
        int NoOfProductBBought { get; set; }
        int NoOfProductCBought { get; set; }
        int NoOfProductDBought { get; set; }
        Dictionary<string, int> ProductNameToPriceMap { get; set; }
        int GetTotalPriceForCheckOut();
    }
}
