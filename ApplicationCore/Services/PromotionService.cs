using ApplicationCore.Entities;
using ApplicationCore.Interface;
using ApplicationCore.Interfaces;
using ApplicationCore.PromotionStrategies;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Core
{
    public class PromotionService : IPromotionService
    {
        public AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions)
        {
            AppliedOffer appliedOffer = new AppliedOffer();
            List<IPromotionStrategy> strategies = new List<IPromotionStrategy>();
            strategies.Add(new AdditionalItemOffer());
            strategies.Add(new ComboOffer());
            try
            {
                foreach (ProductCheckout item in checkoutList)
                {
                    if (item.Quantity > 0)
                    {
                        foreach (var strategy in strategies)
                        {
                            if (strategy.CanExecute(item, promotions))
                            {
                                item.HasOffer = true;
                                item.FinalPrice = strategy.CalculateProductPrice(checkoutList);
                                appliedOffer.TotalPrice += item.FinalPrice;
                                break;
                            }
                        }
                    }
                }
                appliedOffer.Checkouts = checkoutList;
            }
            catch (Exception ex)
            {
                
            }

            return appliedOffer;
        }
    }
}