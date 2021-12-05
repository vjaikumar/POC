
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
  public  class AppliedOffer
   {
        public List<ProductCheckout> Checkouts { get; set; }
        public double TotalPrice { get; set; }
   }
}
