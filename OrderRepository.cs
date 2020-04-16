using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        /// <summary>
        /// Saves the current Order data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the Order record was successfully saved.
        /// </returns>
        public bool Save()
        {
            //TODO: Code that saves the defined Order

            return true;
        }

        /// <summary>
        /// Retrieve one Order.
        /// </summary>
        /// <returns>
        /// A single Order record.
        /// </returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the requested id
            Order order = new Order(orderId);

            // TODO: Code that retrieves the defined order

            // Temporary hard-coded values to return a order
            if (orderId == -1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Retrieve all Orders.
        /// </summary>
        /// <returns>
        /// A List of all Order records.
        /// </returns>
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
    }
}
