﻿using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.Extensions.Configuration;
using PromotionEngine.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;

namespace PromotionEngine.Repository
{
    /// <summary>
    /// Config Repository
    /// </summary>
    public class ConfigRepository : IRepository
    {
        IConfiguration configuration;


        public ConfigRepository()
        {
            try
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(Constants.DataStore, false);


                configuration = builder.Build();
            }
            catch (UnauthorizedAccessException ex)
            {
            }
            catch (Exception ex)
            {

                
            }

        }

        /// <summary>
        /// Get AvilableProducts
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAvilableProducts()
        {
            List<Product> productList = new List<Product>();

            foreach (var item in configuration.GetSection(Constants.Products).GetChildren())
            {
                Product product = new Product();
                configuration.GetSection(item.Path).Bind(product);
                productList.Add(product);
            }

            return productList;
        }

        /// <summary>
        /// Get ProductOffers
        /// </summary>
        /// <returns></returns>
        public List<Promotion> GetProductOffers()
        {
            List<Promotion> lst = new List<Promotion>();
            foreach (var item in configuration.GetSection(Constants.Promotions).GetChildren())
            {
                Promotion product = new Promotion();
                configuration.GetSection(item.Path).Bind(product);
                lst.Add(product);
            }
            return lst;
        }
    }
}
