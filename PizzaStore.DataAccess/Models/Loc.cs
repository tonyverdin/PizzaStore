using System;
using System.Collections.Generic;

namespace PizzaStore.DataAccess.Models
{
    public partial class Loc
    {
        public Loc()
        {
            Customer = new HashSet<Customer>();
            Store = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address1 { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
