using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Library
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassWord { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Address1 { get; set; }
        public string Phonenum { get; set; }
        public string City { get; set; }
        public Address GetAddress()
        {
            return new Address { Address1 = this.Address1, State = this.State, Street = this.Street, City = this.City, PhoneNumber = this.Phonenum };

        }
    }

}
