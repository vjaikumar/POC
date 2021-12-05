
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.PromotionStrategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngine.Core
{
    [TestClass]
    public class ComboOfferTest
    {

        List<Promotion> _promotions;
        IPromotionStrategy _promotionStrategy;
        List<ProductCheckout> _productWithOffer;
        List<ProductCheckout> _productWithoutOffer;

        [TestInitialize]
        public void Setup()
        {
            _promotionStrategy = new ComboOffer();
            _productWithoutOffer = new List<ProductCheckout>() { new ProductCheckout() { ProductCode = "C", Quantity = 1, DefaultPrice = 20 } };
            _productWithOffer = new List<ProductCheckout>() { new ProductCheckout() { ProductCode = "C", Quantity = 1, DefaultPrice = 20 }, new ProductCheckout() { ProductCode = "D", Quantity = 1, DefaultPrice = 15 } };
            _promotions = new List<Promotion>() { new Promotion() { Type = "Single", ProductCode = "A", Price = 130, Quantity = 3 }, new Promotion() { Type = "Single", ProductCode = "B", Price = 45, Quantity = 2 }, new Promotion() { Type = "Combo", ProductCode = "C;D", Price = 30, Quantity = 3 } };
        }


        [TestMethod]
        public void Scenario_ComboOffer_WithOffer()
        {
            double expectedValue = 30;
            bool canExecute = _promotionStrategy.CanExecute(_productWithOffer.FirstOrDefault(), _promotions);
            if (canExecute)
            {
                double actualValue = _promotionStrategy.CalculateProductPrice(_productWithOffer);
                Assert.AreEqual(expectedValue, actualValue);
            }



        }

        [TestMethod]
        public void Scenario_ComboOffer_WithoutOffer()
        {
            double expectedValue = 20;
            bool canExecute = _promotionStrategy.CanExecute(_productWithoutOffer.FirstOrDefault(), _promotions);
            if (canExecute)
            {
                double actualValue = _promotionStrategy.CalculateProductPrice(_productWithoutOffer);
                Assert.AreEqual(expectedValue, actualValue);
            }


        }
    }
    
}
