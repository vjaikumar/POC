using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities;
using ApplicationCore.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngine.Core
{
   [TestClass]
    public class PromotionServiceTest
    {

        List<Promotion> _promotions;

        IPromotionService promotionService;

        [TestInitialize]
             public void Setup()
            {
                promotionService = new IPromotionService();
                _promotions = new List<Promotion>() { new Promotion() { Type = "Single", ProductCode = "A", Price = 130, Quantity = 3 }, new Promotion() { Type = "Single", ProductCode = "B", Price = 45, Quantity = 2 }, new Promotion() { Type = "Combo", ProductCode = "C;D", Price = 30, Quantity = 3 } };

            }

        [TestMethod]
        public void Scenario_A_NoOffer()
        {
           
        }


        [TestMethod]
        public void Scenario_B_TwoOffer_Single()
        {

        }

        [TestMethod]
        public void Scenario_C_TwoOffer_Single()
        {

        }

    }
}
