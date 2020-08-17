using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6th_Assignment_Gurmukh.Biz
{
    public class Employee
    {
        public int ID { get; set; }
        public int JobID { get; set; }
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HireDate { get; set; }
        public Nullable<decimal> Salary { get; set; }

        public Job Job { get; set; }
        public Department Department { get; set; }
    }
}
