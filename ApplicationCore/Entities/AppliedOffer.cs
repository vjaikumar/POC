using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
  public  class AppliedOffer
   {
        public List<ProductCheckout> Checkouts { get; set; }
        public double TotalPrice { get; set; }
   }
}
