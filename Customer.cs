using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            //Default Constructor
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Retrieve the formatted Full Name which is a combination of First & Last Names.
        /// </summary>
        /// <returns>
        /// String "LastName, FirstName"
        ///  or
        /// String "LastName" if FirstName not present
        ///  or
        /// String "FirstName" if LastName not present
        /// </returns>
        public string FullName { 
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <returns>
        /// A single Customer record.
        /// </returns>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
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

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the record was successfully saved.
        /// </returns>
        public bool Save()
        {
            //TODO: Code that saves the defined customer

            return true;
        }

        /// <summary>
        /// Validatest he customer data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the record is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
