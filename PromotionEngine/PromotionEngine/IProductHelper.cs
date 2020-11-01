using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IProductHelper
    {
        Dictionary<string, int> GetProductNameToPriceMap();
    }
}
