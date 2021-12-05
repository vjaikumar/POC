using ApplicationCore.Entities;
using ApplicationCore.Infrastructure;
using ApplicationCore.Interface;
using ApplicationCore.Interfaces;
using ApplicationCore.PresentationLayer;
using PromotionEngine.Core;
using PromotionEngine.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.BusinessLayer
{
    public class Facade
    {
        IPromotionInputOutput consoleLayer;
        IPromotionService promotionService;
        IRepository configManagement;

        List<ProductCheckout> checkoutList;
        AppliedOffer appliedOffer;

        public Facade()
        {
            consoleLayer = new ConsoleLayer();
            promotionService = new PromotionService();
        }

        public bool CheckoutProducts()
        {
            try
            {
                checkoutList = consoleLayer.LoadUserInput();
                return true;
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Error in Checking out Products :" + ex.Message);
            }
            return false;
        }

        public bool ApplyPromotion()
        {
            try
            {
                appliedOffer = promotionService.ApplyPromotion(checkoutList, GetProductOffers());
                return true;
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Error in  Applying Promotio :" + ex.Message);
            }
            return false;
        }

        public bool DisplayTotalPrice()
        {
            try
            {
                if (appliedOffer.Checkouts != null)
                {
                    consoleLayer.DisplayTotalPrice(appliedOffer);
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Error in  Displaying TotalPrice:" + ex.Message);
            }

            return false;
        }
        public List<Promotion> GetProductOffers()
        {
            try
            {
                configManagement = new ConfigRepository();
                return configManagement.GetProductOffers();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Error in Getting Product Offers :" + ex.Message);
            }
            return new List<Promotion>();
        }

        public List<Product> GetAvilableProducts()
        {
            try
            {
                configManagement = new ConfigRepository();
                return configManagement.GetAvilableProducts();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Error in Getting AvilableProducts :" + ex.Message);

            }
            return new List<Product>();
        }
    }
}
