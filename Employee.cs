using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Employee
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }

        public Employee()
        {
            //constructor for employees list
        }
        public Employee (int id, string first, string last, string birthdate, string phone)
        {
            //constructor for id
            this.Id = id;
            this.First = first;
            this.Last = last;
            this.BirthDate = birthdate;
            this.Phone = phone;

        }
    }
}
