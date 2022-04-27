using PromotionEngine.Interface.PromotionType1;
using PromotionEngine.Model;
using System.Threading.Tasks;

namespace PromotionEngine.Service
{
    public class BProduct: IBProductType1
    {
        public Task<int> ApplyPromotion(SKU sku)
        {
            return Task.FromResult((sku.Quantity / 2) * 45 + (sku.Quantity % 2 * 30));
        }
    }
}
