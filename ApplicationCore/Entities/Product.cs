using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
   public class Product:BaseEntity
    {
       
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
