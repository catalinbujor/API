using System;

namespace Centric.UserRepository.Models
{
    public class Address
    {
        private String street { get; set; }
        private String suite { get; set; }
        private String city { get; set; }
        private String zipcode { get; set; }

        public Address(string street, string suite, string city, string zipcode)
        {
            this.street = street;
            this.suite = suite;
            this.city = city;
            this.zipcode = zipcode;
        }

        public String getStreet()
        {
            return street;
        }

    }
}