using System;

namespace PromotionEngine
{
    public class ProductEntriesGreaterThanTotalProductsException : Exception
    {
        //custom exception to be whrows only when summation of products exceeds the total number of products entered.
    }
}
