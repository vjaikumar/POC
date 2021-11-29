using ApplicationCore.Entities;
using System.Collections.Generic;

namespace ApplicationCore.Interface
{
    public interface IPromotionService
    {

        AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions);
    }
}