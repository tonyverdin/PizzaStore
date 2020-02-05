using PizzaStore.DataAccess.Models;
using System.Collections.Generic;

namespace PizzaStore.Library.Interfaces
{
    public interface ICustomer : IRepository<Customer>
    {
        public IEnumerable<Library.Customer> GetCustomers();
    }
}
