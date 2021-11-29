using ApplicationCore.Entities;
using ApplicationCore.Interface;
using System.Collections.Generic;

namespace PromotionEngine.Core
{
    public class PromotionService : IPromotionService
    {
        public AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions)
        {
            AppliedOffer appliedOffer = new AppliedOffer();


            return appliedOffer;
        }
    }
}