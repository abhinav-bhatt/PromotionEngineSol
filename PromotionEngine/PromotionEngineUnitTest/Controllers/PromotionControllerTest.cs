using PromotionEngine.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineUnitTest.Controllers
{
    public class PromotionControllerTest
    {
        [Fact]
        public void Test_PromotionController_ApplyPromotion_Return_SkuPrice()
        {
            //Arrange 
            List<string> skuIds = new List<string>() { "A", "B", "C", "D" };
            //ACT
            PromotionController promotionControllerObj = new PromotionController();
            var result = promotionControllerObj.ApplyPromotion(skuIds);
            //Assert
            Assert.Equal(120, result);
        }
    }
}
