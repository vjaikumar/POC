using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IPromotionStrategy
    {

        bool CanExecute(ProductCheckout product, List<Promotion> promotions);

      
        double CalculateProductPrice(List<ProductCheckout> productCheckoutList);
    }
}
