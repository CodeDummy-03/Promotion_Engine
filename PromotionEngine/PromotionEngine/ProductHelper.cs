using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class ProductHelper
    {
        private static Dictionary<string, int> productNameToPriceMap;

        public Dictionary<string, int> GetProductNameToPriceMap()
        {
            productNameToPriceMap = new Dictionary<string, int>();

            //Add data to productNameToPriceMap here

            return productNameToPriceMap;
        }
    }
}
