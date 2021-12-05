using ApplicationCore.Entities;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface IRepository
    {
        
        List<Product> GetAvilableProducts();

        List<Promotion> GetProductOffers();
    }
}
