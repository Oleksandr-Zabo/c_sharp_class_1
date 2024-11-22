using System;

namespace c_sharp_class_1.Entity
{
    internal class Shop
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Contact_number { get; set; }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Invalid email");
                }
            }
        }

        public Shop()
        {
            Name = "No_name";
            Address = "No_adress";
            Description = "No_description";
            Contact_number = "No_ip_address";
            email = "No_email";
        }
        public Shop(string name) : this()
        {
            Name = name;
        }
        public Shop(string name, string address) : this(name)
        {
            Address = address;
        }
        public Shop(string name, string address, string description) : this(name, address)
        {
            Description = description;
        }

        public Shop(string name, string address, string description, string contact_number) : this(name, address, description)
        {
            Contact_number = contact_number;
        }

        public Shop(string name, string address, string description, string ip_address, string email) : this(name, address, description, ip_address)
        {
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address} \nDescription: {Description} \nContact_number: {Contact_number} \nEmail: {Email}";
        }

    }
}



