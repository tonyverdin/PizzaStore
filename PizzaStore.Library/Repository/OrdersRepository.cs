using PizzaStore.DataAccess.Models;
using PizzaStore.DataAccess.Repositories;
using PizzaStore.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Repository
{
    class OrdersRepository:Repository<Orders>,IOrders
    {
        public OrdersRepository(PizzaboxContext context)
: base(context)
        {
        }
        public PizzaboxContext PizzaboxContext
        {
            get { return Context as PizzaboxContext; }
        }
    }
}
