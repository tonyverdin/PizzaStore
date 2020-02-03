using System;
using System.Collections.Generic;

namespace PizzaStore.DataAccess.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Address { get; set; }
        public string UserPassWord { get; set; }

        public virtual Loc AddressNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
