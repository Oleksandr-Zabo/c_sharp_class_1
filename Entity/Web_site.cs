using System;

namespace c_sharp_class_1.Entity
{
    internal class Web_site
    {

        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Ip_address { get; set; }

        public Web_site()
        {
            Name = "No_name";
            Url = "No_url";
            Description = "No_description";
            Ip_address = "No_ip_address";
        }
        public Web_site(string name): this()
        {
            Name = name;
        }
        public Web_site(string name, string url) : this(name)
        {
            Url = url;
        }
        public Web_site(string name, string url, string description) : this(name, url)
        {
            Description = description;
        }

        public Web_site(string name, string url, string description, string ip_address) : this(name, url, description)
        {
            Ip_address = ip_address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Url: {Url}, Description: {Description}, Ip_address: {Ip_address}";
        }
    }
}



