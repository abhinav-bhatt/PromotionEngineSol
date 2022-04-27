using PromotionEngine.Interface;
using PromotionEngine.Interface.PromotionType1;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PromotionEngine.Service
{
    public class PromotionType1 : IPromotionService
    {
        private readonly IAProductType1 _aProductType1;
        private readonly IBProductType1 _bProductType1;
        private readonly ICDProductType1 _cdProductType1;
        public PromotionType1(IAProductType1 aProductType1, IBProductType1 bProductType1, ICDProductType1 cdProductType1)
        {
            _aProductType1 = aProductType1;
            _bProductType1 = bProductType1;
            _cdProductType1 = cdProductType1;
        }

        public async Task<int> ApplyPromotion(CommonRequest skuIds)
        {
            var task1 = await  Task.Factory.StartNew(() => _aProductType1.ApplyPromotion(skuIds.Skus.Where(x => x.Id.ToUpper() == "A").FirstOrDefault()));
            var task2 = await Task.Factory.StartNew(() => _bProductType1.ApplyPromotion(skuIds.Skus.Where(x => x.Id.ToUpper() == "B").FirstOrDefault()));
            var task3 = await Task.Factory.StartNew(() => _cdProductType1.ApplyPromotion(skuIds.Skus.Where(x => x.Id.ToUpper() == "C" || x.Id == "D").FirstOrDefault()));
            Task.WaitAll(task1, task2, task3);
            int res =  task1.Result + task2.Result + task3.Result;
            return res;
        }
    }
}
