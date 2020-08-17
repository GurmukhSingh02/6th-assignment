
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6th_Assignment_Gurmukh.Biz
{
    public class Job
    {
        public int ID { get; set; }
        public string JobName { get; set; }
        public Nullable<decimal> MinSalary { get; set; }
        public Nullable<decimal> MaxSalary { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
