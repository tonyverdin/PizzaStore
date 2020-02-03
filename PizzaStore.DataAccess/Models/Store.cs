using System;
using System.Collections.Generic;

namespace PizzaStore.DataAccess.Models
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Address { get; set; }

        public virtual Loc AddressNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
