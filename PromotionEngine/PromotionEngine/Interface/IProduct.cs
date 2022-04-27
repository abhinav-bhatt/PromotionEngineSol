using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PromotionEngine.Interface
{
    public interface IProduct
    {
        public Task<int> getPromotionalPrice(CommonRequest request);
    }
}
