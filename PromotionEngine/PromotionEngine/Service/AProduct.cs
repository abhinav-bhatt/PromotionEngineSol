using PromotionEngine.Interface;
using PromotionEngine.Model;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Service
{
    public class AProduct : IPromotionService
    {
        public Task<int> ApplyPromotion(CommonRequest request)
        {
            return Task.FromResult(130 * (request.Skus.Where(x => x.Id.ToUpper() == "A").FirstOrDefault().Quantity / 3) + 
                    50 * (request.Skus.Where(x => x.Id.ToUpper() == "A").FirstOrDefault().Quantity % 3));
        }
    }
}
