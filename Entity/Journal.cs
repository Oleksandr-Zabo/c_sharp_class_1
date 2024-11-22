using System;

namespace c_sharp_class_1.Entity
{
    internal class Journal
    {

        public string Name { get; set; }
        public int Year_of_foundation { get; set; }
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

        public Journal()
        {
            Name = "No_name";
            Year_of_foundation = 1000;
            Description = "No_description";
            Contact_number = "No_ip_address";
            email = "No_email";
        }
        public Journal(string name) : this()
        {
            Name = name;
        }
        public Journal(string name, int year) : this(name)
        {
            Year_of_foundation = year;
        }
        public Journal(string name, int year, string description) : this(name, year)
        {
            Description = description;
        }

        public Journal(string name, int year, string description, string contact_number) : this(name,  year, description)
        {
            Contact_number = contact_number;
        }

        public Journal(string name, int year, string description, string ip_address, string email) : this(name, year, description, ip_address)
        {
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nYear of foundation: {Year_of_foundation} \nDescription: {Description} \nContact_number: {Contact_number} \nEmail: {Email}";
        }

    }
}



