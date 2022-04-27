using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineUnitTest.Model
{
    public class SKUTest
    {
        [Fact]
        public void Test_Model_SKU()
        {
            SKU skuObj = new SKU()
            {
                Id = "A",
                Quantity = 50
            };

            Assert.IsType<string>(skuObj.Id);
            Assert.IsType<decimal>(skuObj.Quantity);
        }
    }
}
