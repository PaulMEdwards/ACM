using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {}
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            //TODO: Code that saves the defined Order

            return true;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
    }
}
