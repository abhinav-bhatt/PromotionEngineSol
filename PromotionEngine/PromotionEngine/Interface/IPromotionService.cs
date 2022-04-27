using PromotionEngine.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PromotionEngine.Interface
{
    public interface IPromotionService
    {
        public Task<int> ApplyPromotion(CommonRequest request);
    }
}
