using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class ProductHelper : IProductHelper
    {
        private static Dictionary<string, int> productNameToPriceMap;

        public Dictionary<string, int> GetProductNameToPriceMap()
        {
            productNameToPriceMap = new Dictionary<string, int>();

            ProductModel productA = new ProductModel();
            productA.ProductName = "A";
            productA.ProductPrice = 50;
            productNameToPriceMap.Add(productA.ProductName, productA.ProductPrice);

            ProductModel productB = new ProductModel();
            productB.ProductName = "B";
            productB.ProductPrice = 30;
            productNameToPriceMap.Add(productB.ProductName, productB.ProductPrice);

            ProductModel productC = new ProductModel();
            productC.ProductName = "C";
            productC.ProductPrice = 20;
            productNameToPriceMap.Add(productC.ProductName, productC.ProductPrice);

            ProductModel productD = new ProductModel();
            productD.ProductName = "D";
            productD.ProductPrice = 15;
            productNameToPriceMap.Add(productD.ProductName, productD.ProductPrice);

            return productNameToPriceMap;
        }
    }
}
