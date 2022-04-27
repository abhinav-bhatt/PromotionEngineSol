using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Interface.PromotionType1
{
    public interface IBProductType1
    {
        public Task<int> ApplyPromotion(SKU skuid);
    }
}
