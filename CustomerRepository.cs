using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Saves the current Customer data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the Customer record was successfully saved.
        /// </returns>
        public bool Save(Customer customer)
        {
            //TODO: Code that saves the passed in Customer

            return true;
        }

        /// <summary>
        /// Retrieve one Customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>
        /// A single Customer record.
        /// </returns>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass int he requested id
            Customer customer = new Customer(customerId);

            // TODO: Code that retrieves the defined customer

            // Temporary hard-coded values to return a customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns>
        /// A List of all Customer records.
        /// </returns>
        public List<Customer> Retrieve()
        {
            //TODO: Code that retrieves all of the customers

            return new List<Customer>();
        }

        /// <summary>
        /// Retrieve all customers with unfulfilled orders.
        /// </summary>
        /// <returns>
        /// A List of all Customer records with unfulfilled orders.
        /// </returns>
        public List<Customer> RetrieveWithOpenOrders()
        {
            //TODO: Code that retrieves all of the customers with unfulfilled orders

            return new List<Customer>();
        }

        /// <summary>
        /// Retrieve all customers in specified region.
        /// </summary>
        /// <returns>
        /// A List of all Customer records in the specified region.
        /// </returns>
        public List<Customer> RetrieveInRegion(int regionId)
        {
            //TODO: Code that retrieves all of the customers in specified region

            return new List<Customer>();
        }
    }
}
