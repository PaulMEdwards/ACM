﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {}
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Validates the Product data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the Product record is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Saves the current Product data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the Product record was successfully saved.
        /// </returns>
        public bool Save()
        {
            //TODO: Code that saves the defined Product

            return true;
        }

        /// <summary>
        /// Retrieve one Product.
        /// </summary>
        /// <returns>
        /// A single Product record.
        /// </returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
    }
}
