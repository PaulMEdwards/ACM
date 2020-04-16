using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
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
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Product product = new Product(productId);

            // TODO: Code that retrieves the defined product

            // Temporary hard-coded values to return a product
            if (productId == -1)
            {
                product.ProductName = "Test Product Name";
                product.ProductDescription = "Test Product Description";
                product.CurrentPrice = 9.95M;
            }

            return product;
        }

        /// <summary>
        /// Retrieve all Products.
        /// </summary>
        /// <returns>
        /// A List of all Product records.
        /// </returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
    }
}
