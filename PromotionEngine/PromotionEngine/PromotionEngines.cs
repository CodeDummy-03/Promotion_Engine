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
            PromotionEngines promotionEngineObject = new PromotionEngines();
            try
            {
                promotionEngineObject.GetQuantityOfProductsBought();


                var totalPriceOfProducts = promotionEngineObject.GetTotalPriceForCheckOut();
                Console.WriteLine("Total Price : " + totalPriceOfProducts);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Invalid entry. Please try again!!!");
            }
            finally
            {
                Console.Read();
            }
        }

        private void GetQuantityOfProductsBought()
        {
            ProductHelper _helper = new ProductHelper();
            ProductNameToPriceMap = _helper.GetProductNameToPriceMap();

            Console.WriteLine("Enter total number of products bought");
            TotalNoOfProductsBought = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter total number of Product A bought (If none enter 0)");
            NoOfProductABought = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter total number of Product B bought (If none enter 0)");
            NoOfProductBBought = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter total number of Product C bought (If none enter 0)");
            NoOfProductCBought = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter total number of Product D bought (If none enter 0)");
            NoOfProductDBought = Int32.Parse(Console.ReadLine());
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
