using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities;
using ApplicationCore.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngine.Core
{
   [TestClass]
    public class PromotionServiceTest
    {

        List<Promotion> _promotions;

        IPromotionService promotionService;

       [TestInitialize]
       public void Setup()
        {
             promotionService = new PromotionService();
            _promotions = new List<Promotion>() { new Promotion() { Type = "Single", ProductCode = "A", Price = 130, Quantity = 3 }, new Promotion() { Type = "Single", ProductCode = "B", Price = 45, Quantity = 2 }, new Promotion() { Type = "Combo", ProductCode = "C;D", Price = 30, Quantity = 3 } };

        }

        [TestMethod]
        public void Scenario_A_NoOffer()
        {
            List<ProductCheckout> orderCart = new List<ProductCheckout>() { new ProductCheckout() { ProductCode = "A", Quantity = 1, DefaultPrice = 50 }, new ProductCheckout() { ProductCode = "B", Quantity = 1, DefaultPrice = 30 }, new ProductCheckout() { ProductCode = "C", Quantity = 1, DefaultPrice = 20 } };
            double expectedValue = 100;
            double actualValue = promotionService.ApplyPromotion(orderCart, _promotions).TotalPrice;
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void Scenario_B_TwoOffer_Single()
        {

        }

        [TestMethod]
        public void Scenario_C_TwoOffer_Single()
        {

        }

    }
}
