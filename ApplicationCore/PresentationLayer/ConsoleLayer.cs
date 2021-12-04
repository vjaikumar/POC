using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.PresentationLayer
{
    public class ConsoleLayer : IPromotionInputOutput
    {
        bool IPromotionInputOutput.DisplayTotalPrice(AppliedOffer appliedOffer)
        {
            throw new NotImplementedException();
        }

        List<ProductCheckout> IPromotionInputOutput.LoadUserInput()
        {
            throw new NotImplementedException();
        }
    }
}
