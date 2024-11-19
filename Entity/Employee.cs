using System;

namespace c_sharp_class_1.Entity
{
    internal class Employee
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactPhone { get; set; }
        public string WorkEmail { get; set; }
        private string position;
        public string Position {
            get{
                return position;
            }
            set {
                position = value;
            }
        }
        
        public string[] job_descriptions = new string[] { };
        public string this[int index]
        {
            get { return job_descriptions[index]; }
            set
            {
                if (index >= 0 && index < job_descriptions.Length)
                {
                    job_descriptions[index] = value;
                }
                else if (index == job_descriptions.Length)
                {
                    Array.Resize(ref job_descriptions, job_descriptions.Length + 1);
                    job_descriptions[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }

        public Employee() {
            FullName = "";
            BirthDate = DateTime.Now;
            ContactPhone = "";
            WorkEmail = "";
            position = "";  
        }

        public Employee(string fullName) : this()
        {
            FullName = fullName;
        }

        public Employee(string fullName, DateTime birthDate) : this(fullName)
        {
            BirthDate = birthDate;
        }

        public Employee(string fullName, DateTime birthDate, string contactPhone) : this(fullName, birthDate)
        {
            ContactPhone = contactPhone;
        }

        public Employee(string fullName, DateTime birthDate, string contactPhone, string workEmail) : this(fullName, birthDate, contactPhone)
        {
            WorkEmail = workEmail;
        }

        public Employee(string fullName, DateTime birthDate, string contactPhone, string workEmail, string position) : this(fullName, birthDate, contactPhone, workEmail)
        {
            Position = position;
        }

        public Employee(string fullName, DateTime birthDate, string contactPhone, string workEmail, string position, string[] jobDescription): this(fullName, birthDate, contactPhone, workEmail, position)
        {
            job_descriptions = jobDescription;
        }


        public override string ToString()
        {
            string jobDescription = "";
            foreach (string job in job_descriptions)
            {
                jobDescription += job + ", ";
            }
            return $"Full Name: {FullName}\nBirth Date: {BirthDate.ToShortDateString()}\nContact Phone: {ContactPhone}\nWork Email: {WorkEmail}\nPosition: {Position}\nJob Description: {jobDescription}";
        }
    }


}

