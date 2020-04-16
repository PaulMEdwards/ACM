using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {}
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validates the OrderItem data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the OrderItem record is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Saves the current OrderItem data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the OrderItem record was successfully saved.
        /// </returns>
        public bool Save()
        {
            //TODO: Code that saves the defined OrderItem

            return true;
        }

        /// <summary>
        /// Retrieve one OrderItem.
        /// </summary>
        /// <returns>
        /// A single OrderItem record.
        /// </returns>
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
    }
}
