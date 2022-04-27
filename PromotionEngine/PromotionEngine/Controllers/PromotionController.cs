using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PromotionEngine.Interface;
using PromotionEngine.Model;

namespace PromotionEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _ipromotionservice;
        public PromotionController(IPromotionService ipromotionService)
        {
            _ipromotionservice = ipromotionService;
        }

        // GET: api/Promotion/5
        [HttpPost]
        [Route("ApplyPromotion")]
        public async Task<ActionResult> ApplyPromotion([FromBody]CommonRequest request)
        {
            try
            {
                var res = await _ipromotionservice.ApplyPromotion(request);

                return StatusCode(200, res);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "There is some issue in applying the promotion");
            }
        }


        
    }
}
