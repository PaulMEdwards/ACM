using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Tests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(-1)
            {
                ProductName = "Test Product Name",
                ProductDescription = "Test Product Description",
                CurrentPrice = 9.95M
            };

            //-- Act
            var actual = productRepository.Retrieve(-1);

            //-- Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
