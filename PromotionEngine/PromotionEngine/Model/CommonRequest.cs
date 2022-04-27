using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class CommonRequest
    {
        public List<SKU> Skus { get; set; };
        public PromotionEmun PromotionEmun { get; set; }
    }
}
