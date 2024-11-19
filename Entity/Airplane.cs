namespace c_sharp_class_1.Entity
{
    internal class Airplane
    {
        public string Name { get; set; }
        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
            }
        }
        public int YearOfManufacture { get; set; }
        public string Type { get; set; }


        public Airplane()
        {
            Name = "";
            manufacturer = "";
            YearOfManufacture = 0;
            Type = "";
        }
        public Airplane(string name) : this()
        {
            Name = name;
        }
        public Airplane(string name, string manufacturer) : this(name)
        {
            Manufacturer = manufacturer;
        }
        public Airplane(string name, string manufacturer, int yearOfManufacture) : this(name, manufacturer)
        {
            YearOfManufacture = yearOfManufacture;
        }


        public Airplane(string name, string manufacturer, int yearOfManufacture, string type) : this(name, manufacturer, yearOfManufacture)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Manufacturer: {Manufacturer}, Year of Manufacture: {YearOfManufacture}, Type: {Type}";
        }
    }
       
}
