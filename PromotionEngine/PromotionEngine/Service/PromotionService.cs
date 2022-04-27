using PromotionEngine.Interface;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Service
{
    public class PromotionService : IPromotionService
    {
        private readonly Func<PromotionEmun, IProduct> _service;
        public PromotionService(Func<PromotionEmun, IProduct> service)
        {
            _service = service;
        }
        public async Task<int> ApplyPromotion(CommonRequest request)
        {
            var result = await _service(request.PromotionEmun).getPromotionalPrice(request);
            return result;
        }
    }
}
