using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.PromotionStrategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Core
{
    public class AdditionalItemOfferTest
    {
        List<Promotion> _promotions;
        ProductCheckout _productWithOffer;
        ProductCheckout _productWithoutOffer;
        ProductCheckout _productWithOfferExtra;
        IPromotionStrategy _promotionStrategy;

        [TestInitialize]
        public void Setup()
        {
            _promotionStrategy = new AdditionalItemOffer();
            _productWithOffer = new ProductCheckout() { ProductCode = "A", Quantity = 3, DefaultPrice = 50 };
            _productWithOfferExtra = new ProductCheckout() { ProductCode = "A", Quantity = 4, DefaultPrice = 50 };
            _productWithoutOffer = new ProductCheckout() { ProductCode = "A", Quantity = 2, DefaultPrice = 50 };
            _promotions = new List<Promotion>() { new Promotion() { Type = "Single", ProductCode = "A", Price = 130, Quantity = 3 }, new Promotion() { Type = "Single", ProductCode = "B", Price = 45, Quantity = 2 }, new Promotion() { Type = "Combo", ProductCode = "C;D", Price = 30, Quantity = 3 } };
        }

    }
}
