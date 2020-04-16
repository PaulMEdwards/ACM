using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {}
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        /// <summary>
        /// Validates the Address data.
        /// </summary>
        /// <returns>
        /// Boolean indicating whether the Address record is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(StateProvince)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;

            return isValid;
        }
    }
}
