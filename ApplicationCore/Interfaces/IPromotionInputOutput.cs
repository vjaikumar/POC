using ApplicationCore.Entities;
using System.Collections.Generic;


namespace ApplicationCore.Interfaces
{
   public interface  IPromotionInputOutput
    {
        List<ProductCheckout> LoadUserInput();

        bool DisplayTotalPrice(Entities.AppliedOffer appliedOffer);
    }
}
