using ApplicationCore.Entities;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface IPromotionStrategy
    {

        bool CanExecute(ProductCheckout product, List<Promotion> promotions);

        double CalculateProductPrice(List<ProductCheckout> productCheckoutList);
    }
}
