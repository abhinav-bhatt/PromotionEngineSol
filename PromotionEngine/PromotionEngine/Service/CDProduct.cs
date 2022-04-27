using PromotionEngine.Interface;
using PromotionEngine.Interface.PromotionType1;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Service
{
    public class CDProduct : ICDProductType1
    {
        public Task<int> ApplyPromotion(SKU sku)
        {
            return Task.FromResult((sku.Quantity / 2) * 45 + (sku.Quantity % 2 * 30));
        }
    }
}
