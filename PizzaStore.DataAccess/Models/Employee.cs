using System;
using System.Collections.Generic;

namespace PizzaStore.DataAccess.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string EmployeePassword { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
