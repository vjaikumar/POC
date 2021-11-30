using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.PromotionStrategies
{
    public class AdditionalItemOffer : IPromotionStrategy
    {
        private Promotion appliedPromotion;
        private ProductCheckout ProductCheckout;

        public AdditionalItemOffer()
        {
            appliedPromotion = new Promotion();
            ProductCheckout = new ProductCheckout();
        }

        /// <summary>
        /// Can Execute
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        public bool CanExecute(ProductCheckout product, List<Promotion> promotions)
        {
            

            return false;
        }

        /// <summary>
        /// Calculate ProductPrice
        /// </summary>
        /// <param name="productCheckoutList"></param>
        /// <returns></returns>
        public double CalculateProductPrice(List<ProductCheckout> productCheckoutList)
        {
            double finalPrice = 0;
           

            return finalPrice;
        }
    }
}
