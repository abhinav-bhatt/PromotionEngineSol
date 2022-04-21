using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PromotionEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        // GET: api/Promotion
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Promotion/5
        [HttpGet("{id}", Name = "Get")]
        public decimal ApplyPromotion(List<string> skuIds)
        {
            return 120;
        }


        
    }
}
