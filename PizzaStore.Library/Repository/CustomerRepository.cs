using PizzaStore.DataAccess.Models;
using PizzaStore.DataAccess.Repositories;
using PizzaStore.Library;
using PizzaStore.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore.DataAccess.Repository
{
    class CustomerRepository:Repository<Customer>,ICustomer
    {
        public CustomerRepository(PizzaboxContext context)
: base(context)
        {
        }
        public PizzaboxContext PizzaboxContext
        {
            get { return Context as PizzaboxContext; }
        }

        
    }
}
