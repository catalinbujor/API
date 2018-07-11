using System;

namespace Centric.UserRepository.Models
{
    public class User
    {
        private int id { get; set; }
        private String name { get; set; }
        private String username { get; set; }
        private String email { get; set; }
        private String phone { get; set; }
        private String website { get; set; }

        private Company company;
        private Address address;

        public User(int id, string name, string username, string email, string phone, string website, Company company, Address address)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.email = email;
            this.phone = phone;
            this.website = website;
            this.company = company;
            this.address = address;
        }

        public String getName()
        {
            return name;
        }
        public Address GetAddress()
        {
            return address;
        }
    }
}